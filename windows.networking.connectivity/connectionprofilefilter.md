---
-api-id: T:Windows.Networking.Connectivity.ConnectionProfileFilter
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectionProfileFilter : Windows.Networking.Connectivity.IConnectionProfileFilter, Windows.Networking.Connectivity.IConnectionProfileFilter2
-->

# Windows.Networking.Connectivity.ConnectionProfileFilter

## -description
Represents the desired criteria for a connection profile. The filter is used to generate a list of [ConnectionProfile](connectionprofile.md) objects.

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
* Setting multiple cost related constraints (for example NetworkCostType plus Roaming or OverDataLimit states) can lead to brittle logic—query the profile's ConnectionCost after selection instead.

Example (C#):

```csharp
var filter = new Windows.Networking.Connectivity.ConnectionProfileFilter
{
    IsWlanConnectionProfile = true,
    NetworkCostType = Windows.Networking.Connectivity.NetworkCostType.Unrestricted
};

var profiles = await Windows.Networking.Connectivity.NetworkInformation.FindConnectionProfilesAsync(filter);
```

### Selecting a cellular profile with minimum connectivity level

```csharp
var filter = new Windows.Networking.Connectivity.ConnectionProfileFilter
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

## -examples
(See code snippets above.)

## -see-also
[ConnectionProfile](connectionprofile.md), NetworkInformation.FindConnectionProfilesAsync
