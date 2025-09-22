---
-api-id: T:Windows.Networking.Connectivity.ConnectionProfileFilter
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectionProfileFilter : Windows.Networking.Connectivity.IConnectionProfileFilter, Windows.Networking.Connectivity.IConnectionProfileFilter2
-->

# Windows.Networking.Connectivity.ConnectionProfileFilter

## -description
The ConnectionProfileFilter class defines a set of properties that are used to improve the relevance of [FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md) results.

At least one property must be specified, otherwise the object is not used as for filtering.

## -remarks
Create an instance of ConnectionProfileFilter when you need a subset of profiles instead of relying only on the current profile returned by NetworkInformation.GetInternetConnectionProfile.

Usage guidance:

1. Start with the minimal set of properties. Many filters (for example IsWlanConnectionProfile and IsWwanConnectionProfile) are mutually exclusive or naturally reduce the result set to zero if over-constrained.
2. Use the PurposeGuid only when you know the target scenario (for example a VPN or specific provisioned profile) and have obtained the GUID from policy or management infrastructure. An incorrect GUID will silently yield no matches.
3. Combine NetworkCostType and NetworkConnectivityLevel constraints only if you must; connectivity state can vary frequently (especially on mobile / metered connections) and may cause races if evaluated before connection stabilization.
4. If you need usage data after filtering, enumerate the resulting profiles and then call GetNetworkUsageAsync on each rather than attempting to predict usage characteristics from filter inputs.
5. Prefer using IsWlanConnectionProfile or IsWwanConnectionProfile over examining the profile name string to determine access technology.

Common pitfalls:

* Setting both IsWlanConnectionProfile and IsWwanConnectionProfile to true expecting a union results in no profiles (they are treated as AND conditions). Leave both false for "any technology".
* Providing a PurposeGuid without confirming its presence on the device yields an empty result and can mask bugs.
* Setting multiple cost related constraints (for example NetworkCostType plus Roaming or OverDataLimit states) can lead to brittle logic; query the profile's ConnectionCost after selection instead.

Avoid reusing and toggling properties on a single filter instance between calls. Leftover state can unintentionally over-constrain and yield zero results (see carrier / service provider filtering example below).

Functional selection notes:

* To enumerate all currently connected profiles across technologies (e.g., Ethernet and Wi-Fi), set `IsConnected = true` and leave `IsWlanConnectionProfile` / `IsWwanConnectionProfile` unset.
* Setting both `IsWlanConnectionProfile` and `IsWwanConnectionProfile` never produces a union; it yields no results because both conditions must be true simultaneously.
* A single filter cannot express logical OR across technologies with `ServiceProviderGuid`; construct separate filters per technology when needed.

## -examples
Carrier / service provider filtering (C#):

```csharp
var carrierId = Guid.Parse("f68cd4bf-a388-4e8b-91ea-54dd6dd901c0"); // Replace with your known service provider GUID

// WWAN profiles
var wwanFilter = new ConnectionProfileFilter
{
    IsWwanConnectionProfile = true,
    ServiceProviderGuid = carrierId
};
var wwanProfiles = await NetworkInformation.FindConnectionProfilesAsync(wwanFilter);

// WLAN offload (create a new filter instead of mutating the prior one)
var wlanFilter = new ConnectionProfileFilter
{
    IsWlanConnectionProfile = true,
    ServiceProviderGuid = carrierId
};
var wlanProfiles = await NetworkInformation.FindConnectionProfilesAsync(wlanFilter);
```

### Selecting a cellular profile with minimum connectivity level

```csharp
var filter = new ConnectionProfileFilter
{
    IsWwanConnectionProfile = true,
    NetworkConnectivityLevel = Windows.Networking.Connectivity.NetworkConnectivityLevel.InternetAccess
};

var cellularProfiles = await Windows.Networking.Connectivity.NetworkInformation.FindConnectionProfilesAsync(filter);
```

After filtering, validate cost:

```csharp
foreach (var p in cellularProfiles)
{
    var cost = p.GetConnectionCost();
    if (cost.Roaming) { /* adjust behavior */ }
}
```

## -see-also
[ConnectionProfile](connectionprofile.md), [FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md)
