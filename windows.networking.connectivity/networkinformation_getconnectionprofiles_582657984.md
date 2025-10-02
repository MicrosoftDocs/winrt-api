---
-api-id: M:Windows.Networking.Connectivity.NetworkInformation.GetConnectionProfiles
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.ConnectionProfile> GetConnectionProfiles()
-->

# Windows.Networking.Connectivity.NetworkInformation.GetConnectionProfiles

## -description
Enumerates all connection profiles (active or not) currently known to the system for the local machine.

## -returns
A read-only list of [ConnectionProfile](connectionprofile.md) objects. The list may be empty.

## -remarks
### Purpose
Use when you need the full set of provisioned / known connection profiles (including those not currently connected).  
For only the profile providing current Internet connectivity, call
[GetInternetConnectionProfile](networkinformation_getinternetconnectionprofile_255647281.md).

### Characteristics
- Includes connected, disconnected, and provisioned-but-idle profiles (for example, remembered Wi-Fi networks, cellular APN profiles).
- May include profiles with limited or no present connectivity level.
- Order is implementation-defined; do not rely on list ordering.

### When to prefer filtering
If you need only a subset (for example, connected Wi-Fi profiles), use
[FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md) with a
[ConnectionProfileFilter](connectionprofilefilter.md) to reduce enumeration and post-processing cost.

### Typical workflow
1. Call the `GetConnectionProfiles` method.
2. Iterate profiles; inspect connectivity via `GetNetworkConnectivityLevel`.
3. For each desired profile, query additional details (cost: `GetConnectionCost`, usage: `GetNetworkUsageAsync`, data plan: `GetDataPlanStatus`).

### Performance guidance
- Enumeration is lightweight but avoid calling in tight loops; cache results for a reasonable interval if your scenario allows.
- Re-enumerate on network status change events rather than polling.

### Comparison
| Need | API |
| -- | -- |
| Current Internet-active profile | `GetInternetConnectionProfile` |
| All known profiles (broad inventory) | `GetConnectionProfiles` |
| Filtered subset (e.g., only connected WWAN) | `FindConnectionProfilesAsync` + `ConnectionProfileFilter` |

### Example notes
Use the examples in the -examples section for up-to-date patterns. Legacy samples that mutate global variables or rely on helper functions (e.g., `getConnectionProfileInfo`) are omitted for clarity.


## -examples
### List profile names and connectivity (C#)

```csharp
using Windows.Networking.Connectivity;
using System.Linq;
using System.Text;

var sb = new StringBuilder();
var profiles = NetworkInformation.GetConnectionProfiles();
if (profiles.Count == 0)
{
    sb.AppendLine("No profiles found.");
}
else
{
    foreach (var p in profiles)
    {
        var level = p.GetNetworkConnectivityLevel();
        sb.AppendLine($"{p.ProfileName} : {level}");
    }
}
System.Diagnostics.Debug.WriteLine(sb.ToString());
```

### List profile names (JavaScript)

```javascript
const profiles = Windows.Networking.Connectivity.NetworkInformation.getConnectionProfiles();
if (profiles.length === 0) {
    console.log("No profiles found.");
} else {
    profiles.forEach(p => {
        const level = p.getNetworkConnectivityLevel();
        console.log(`${p.profileName} : ${level}`);
    });
}
```

## -see-also

[ConnectionProfile](connectionprofile.md),
[ConnectionProfileFilter](connectionprofilefilter.md),
[NetworkInformation.FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md)

