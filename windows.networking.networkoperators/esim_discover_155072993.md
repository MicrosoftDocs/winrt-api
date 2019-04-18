---
-api-id: M:Windows.Networking.NetworkOperators.ESim.Discover
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public ESimDiscoverResult ESim.Discover()
-->

# Windows.Networking.NetworkOperators.ESim.Discover

## -description
Performs an eSIM profile discovery operation using the default SMDS address.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -returns
An [ESimDiscoverResult](esimdiscoverresult.md) object representing the result of the operation.

## -remarks
The profile discovery operation involves contacting a remote server. That server can be either the discovery server whose address is preset in the eSIM, or a server address provided by a mobile operator (MO). The server can return a list of events that contain the information of the next server hop, or it can download a profile metadata. Once your application gets the profile metadata, you can choose to install or reject the profile based on your own business logic. Profile discovery is serial, meaning that until your application makes the installation decision for the current profile, it is not allowed to discover other profiles.

For each hop, your application must visit the hop to know which type of data is returned by the server. However, profile metadata can have download time limits. Thus, your application should avoid unnecessary download of other profile metadata if it has some hint of where the profile of interest should be.

## -see-also

## -examples

### Scenario 1
Discover profile with a given SM-DP+ address and a matching ID. The mobile operator gives the app the SMDP address, which is a FQDN of a server such as `smdp.contoso.com` and the MatchingID `abcd1234` to locate the profile. The assumption is that the client has already obtained an [ESim](esim.md) object from [ESimWatcher](esimwatcher.md).

```csharp
async void Scenario1_DiscoverWithSmdpAddress(ESim esim, String smdpAddress, String matchingId)
{
    ESimDiscoverResult discoverResult = await esim.DiscoverAsync(
        smdpAddress,
        matchingId);
 
    if (discoverResult.Result.Status != ESimOperationStatus.Success)
    {
        discoveryStatusBar.Text = GetDiscoveryResultString("Discover failed", discoverResult.Result.Status);
        return;
    }
 
    if (discoverResult.Kind == ESimDiscoverResultKind.ProfileMetadata )
    {
        ESimProfileMetadata profileMetadata = discoverResult.ProfileMetadata;
        ESimOperationResult result = await profileMetadata.ConfirmInstallAsync();
        if (result.Status != ESimOperationStatus.Success)
        {
            discoveryStatusBar.Text = GetDiscoveryResultString("Couldn't install profile", result.Status);
        }
        else
        {
            discoveryStatusBar.Text = "Success";
        }
 
    }
    else
    {
        // If an SMDP address is given, the app will expect a profile.
        discoveryStatusBar.Text = "Unexpected result from server";
    }
}
```

### Scenario 2
Discover profile with no server info. The mobile operator doesn't provide any server information about the profile to download. In this case, the app can still start the discovery process. The app traverses all the available profiles for the eSIM. This may lead to touching profiles that don't belong to the mobile operator if there are more than one profile discoverable by the eSIM. However, with no information from the mobile operator, this is a technique you can use.

```csharp
async Task<bool> Scenario2_DiscoverProfile(ESim esim, String rspServerAddress, String matchingId)
{
    ESimDiscoverResult discoverResult = await esim.DiscoverAsync(
        rspServerAddress,
        matchingId);
 
    if (discoverResult.Result.Status != ESimOperationStatus.Success)
    {
        discoveryStatusBar.Text = GetDiscoveryResultString("Discover failed", discoverResult.Result.Status);
        return false;
    }
 
    if (discoverResult.Kind == ESimDiscoverResultKind.Events)
    {
        IList<ESimDiscoverEvent> discoveryEvents = discoverResult.Events;
        foreach (ESimDiscoverEvent discoverEvent in discoveryEvents)
        {
            // Recursively visit the server hops in event list.
            foundProfile = await Scenario2_DiscoverProfile(
                esim,
                discoverEvent.RspServerAddress,
                discoverEvent.MatchingId);
 
            if (foundProfile) break;
        }
    }
    else if (discoverResult.Kind == ESimDiscoverResultKind.ProfileMetadata)
    {
        ESimProfileMetadata profileMetadata = discoverResult.ProfileMetadata;
 
        // There can be multiple profiles waiting for download. In a general profile
        // discovery, the app may ask the user's consent for each profile (metadata). 
        bool okToInstall = await GetUserConsentForProfileDownload(profileMetadata);
 
        // OR ...
        // In the use case where the app is expecting a certain profile, the app may 
        // check the Id, ProviderName and ProviderId of the returned profile metadata 
        // to determine whether it is the expected profile.
        //
        // For example:
        // okToInstall = IsExpectedProfile(profileMetadata);
        
        if (okToInstall)
        {
            ESimOperationResult result = await profileMetadata.ConfirmInstallAsync();
            if (result.Status != ESimOperationStatus.Success)
            {
                discoveryStatusBar.Text = GetDiscoveryResultString("Couldn't install profile", result.Status);
            }
 
            // Regardless of installation result, the desired profile has been found.
            // Return early to avoid touching other profiles unnecessarily.
            return true;
        }
        else
        {
            ESimOperationResult result = await profileMetadata.PostponeInstallAsync();
            if (result.Status != ESimOperationStatus.Success)
            {
                // App can choose to ignore the result as this is to postpone 
                // installation. Error can be caused by a timeout or bad connection 
                // with the remote server. All these causes will effectively postpone
                // the install.
            }
        }
    }

    return false;
}

async void Scenario2_DiscoverWithDefault(ESim esim)
{
    await Scenario2_DiscoverProfile(esim, null, null);
}
```

### Scenario 3
Discover profiles with given server address subfix. The mobile operator hosts many profile servers but it declines to give the profile server address to the app for security reasons. The app is asked to check profiles saved on server with a domain name ending with `contoso.com`. Some of the logic is the same as that of Scenario 2. The example code here calls the function Scenario2_DiscoverProfile().

```csharp
async void Scenario3_DiscoverProfileWithServerInfo(ESim esim, String serverDomainNameSubfix)
{
    ESimDiscoverResult discoverResult = await esim.DiscoverAsync();
 
    if (discoverResult.Result.Status != ESimOperationStatus.Success)
    {
        discoveryStatusBar.Text = GetDiscoveryResultString("Discover failed", discoverResult.Result.Status);
        return;
    }
 
    if (discoverResult.Kind == ESimDiscoverResultKind.Events)
    {
        IList<ESimDiscoverEvent> discoverEvents = discoverResult.Events;
        foreach (ESimDiscoverEvent discoverEvent in discoverEvents)
        {
            // Check if this is the expected event.
            if (discoverEvent.RspServerAddress.EndsWith(serverDomainNameSubfix))
            {
                bool foundProfile = await Scenario2_DiscoveryProfile(
                    esim,
                    discoverEvent.RspServerAddress,
                    discoverEvent.MatchingId);
                
                if (foundProfile) break;
            }
        }
    }
    else 
    {
        // The first discovery is guaranteed to return event list.
        discoveryStatusBar.Text = "Unexpected result from server";
    }
 
    return;
}
```

### Scenario 4
A sneak peek of available discovery results. An eSIM utility app shows the list of discovery results for the user. The user can later choose which is the next hop based on their interest. To get the list, the app calls the discovery API without any parameters.

```csharp
Task<IList<ESimDiscoverEvent>> void Scenario4_ReviewDiscoveryResults(ESim esim)
{
    ESimDiscoverResult discoverResult = await esim.DiscoverAsync();
 
    if (discoverResult.Result.Status != ESimOperationStatus.Success)
    {
        discoveryStatusBar.Text = GetDiscoveryResultString("Discover failed", discoverResult.Result.Status);
 
        return new List<ESimDiscoverResult>();
    }
 
    if (discoverResult.Kind == ESimDiscoverResultKind.Events)
    {
        return discoverResult.Events;
    }
    else
    {
        // The first discovery is guaranteed to return event list.
        discoveryStatusBar.Text = "Unexpected result from server";
    }
 
    return new List<ESimDiscoverResult>();
}
```

### Scenario 5
Synchronized API call. A utility app is trying to see whether there are discovery results available for the eSIM. They create a function named HasAvailableEventsToDiscover(). It is guaranteed to running in the app's threadpool, and would like to have the result returned synchronously.

```csharp
bool Scenario5_HasAvailableEventsToDiscover(ESim esim)
{
    ESimDiscoverResult discoverResult = esim.Discover();
 
    if (discoverResult.Result.Status != ESimOperationStatus.Success)
    {
        discoveryStatusBar.Text = GetDiscoveryResultString("Discover failed", discoverResult.Result.Status);
        return false;
    }
 
    // The discover result will always return the default SMDP+ address as
    // the first result so that it can be considered by the caller as one
    // possible profile source. Any more events in the list mean that the
    // discovery server has discovery events available.
    if (discoverResult.Kind == ESimDiscoverResultKind.Events
        && discoverResult.Count > 1)
    {
        return true;
    }
 
    return false;
}
```

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
