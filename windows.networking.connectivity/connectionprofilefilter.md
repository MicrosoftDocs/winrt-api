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

At least one property must be set; an empty filter is ignored and yields no filtering effect.

## -remarks

Usage guidance:

Create a filter with only the predicates you actually need; unspecified properties are treated as wildcards. At least one property must be set or the filter is ignored.

Common patterns:

* Enumerate only currently connected WLAN profiles.
* Find WWAN profiles that are roaming or metered.
* Select profiles with a specific purpose identifier (`PurposeGuid`).

Best practices:

* Do not set mutually exclusive booleans (for example, `IsWlanConnectionProfile` and `IsWwanConnectionProfile`) to true simultaneously; this will always return zero results.
* Avoid over‑filtering: start broad (e.g., connected + WLAN) then refine using properties on returned `ConnectionProfile` objects.
* Re‑issue the query after a `NetworkInformation.NetworkStatusChanged` event rather than caching earlier results.
* `PurposeGuid` is for advanced scenarios (OEM / enterprise provisioning). Only specify it when you know the provisioning GUID.

Examples:

Filter for connected Wi‑Fi profiles (C#):

```csharp
var filter = new ConnectionProfileFilter
{
	IsConnected = true,
	IsWlanConnectionProfile = true
};
var wifiProfiles = await NetworkInformation.FindConnectionProfilesAsync(filter);
```

Filter for roaming WWAN profiles with cost awareness (C++/WinRT):

```cpp
ConnectionProfileFilter filter;
filter.IsWwanConnectionProfile(true);
filter.IsConnected(true);
// 'IsRoaming' property is on ConnectionCost, so filter first then inspect.
auto profiles = co_await NetworkInformation::FindConnectionProfilesAsync(filter);
for (auto const& p : profiles)
{
	auto cost = p.GetConnectionCost();
	if (cost.Roaming())
	{
		// Handle roaming profile
	}
}
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | PurposeGuid |

## -examples
Find profiles matching a provisioning purpose (C#):

```csharp
Guid purpose = /* known provisioning GUID */;
var filter = new ConnectionProfileFilter { PurposeGuid = purpose };
var matches = await NetworkInformation.FindConnectionProfilesAsync(filter);
```

## -see-also
[FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md)
