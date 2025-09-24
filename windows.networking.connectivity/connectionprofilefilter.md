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
Create an instance of ConnectionProfileFilter when you need a subset of profiles instead of relying only on the
current profile returned by NetworkInformation.GetInternetConnectionProfile or the all-inclusive enumeration
provided by GetConnectionProfiles which includes all profiles including those which are offline.

Usage guidance:

* Start with the minimal set of properties. Many filters (for example IsWlanConnectionProfile and IsWwanConnectionProfile) are mutually exclusive or naturally reduce the result set to zero if over-constrained.
* Use the PurposeGuid only when you know the target scenario (for example a specific WWAN profile or carrier-provisioned connection) and have obtained the GUID from carrier provisioning or enterprise policy infrastructure. An incorrect GUID will silently yield no matches.
* Combine NetworkCostType and NetworkConnectivityLevel constraints only if you must; connectivity state can vary frequently (especially on mobile / metered connections) and may cause races if evaluated before connection stabilization.
* If you need usage data after filtering, enumerate the resulting profiles and then call GetNetworkUsageAsync on each rather than attempting to predict usage characteristics from filter inputs.
* Prefer using IsWlanConnectionProfile or IsWwanConnectionProfile over examining the profile name string to determine access technology.

Common pitfalls:

* Setting both IsWlanConnectionProfile and IsWwanConnectionProfile to true expecting a union results in no profiles (they are treated as AND conditions). Leave both false for "any technology".
* Providing a PurposeGuid without confirming its presence on the device yields an empty result and can mask bugs.
* Setting multiple cost related constraints (for example NetworkCostType plus Roaming or OverDataLimit states) can lead to brittle logic; query the profile's ConnectionCost after selection instead.

Avoid reusing and toggling properties on a single filter instance between calls. Leftover state can unintentionally over-constrain and yield zero results (see carrier / service provider filtering example below).

Functional selection notes:

* To enumerate all currently connected profiles across technologies (e.g., Ethernet and Wi-Fi), set `IsConnected = true` and leave `IsWlanConnectionProfile` / `IsWwanConnectionProfile` unset.
* A single filter cannot express logical OR across technologies with `ServiceProviderGuid`; construct separate filters per technology when needed.

## -examples
Carrier / service provider filtering (C#):

```csharp
using Windows.Networking.Connectivity;

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
using Windows.Networking.Connectivity;

var filter = new ConnectionProfileFilter
{
    IsWwanConnectionProfile = true,
    NetworkConnectivityLevel = NetworkConnectivityLevel.InternetAccess
};

var cellularProfiles = await NetworkInformation.FindConnectionProfilesAsync(filter);
```

After filtering, validate cost:

```csharp
using Windows.Networking.Connectivity;

foreach (var p in cellularProfiles)
{
    var cost = p.GetConnectionCost();
    if (cost.Roaming) { /* adjust behavior */ }
}
```

## -see-also
[ConnectionProfile](connectionprofile.md), [FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md)
