---
-api-id: T:Windows.Networking.Connectivity.DataPlanStatus
-api-type: winrt class
---

<!-- Class syntax.
public class DataPlanStatus : Windows.Networking.Connectivity.IDataPlanStatus
-->

# Windows.Networking.Connectivity.DataPlanStatus

## -description
Represents current data plan status (limits, usage, cycle metadata) for a connection profile.

## -remarks
### Obtaining an instance
Call [ConnectionProfile.GetDataPlanStatus](connectionprofile_getdataplanstatus_2024938217.md) on a profile obtained via:

- [NetworkInformation.GetInternetConnectionProfile](networkinformation_getinternetconnectionprofile_255647281.md)
- [NetworkInformation.FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md)
- [NetworkInformation.GetConnectionProfiles](networkinformation_getconnectionprofiles_582657984.md)

### Null handling
> [!IMPORTANT]
> Always null-check the returned `DataPlanStatus`. Some profiles (for example unmanaged Wi-Fi hotspots) do not expose
> plan information and return null.

### Core elements
| Property | Meaning / Guidance |
| -- | -- |
| [DataPlanUsage](dataplanusage.md) | Current measured usage (may lag real traffic) |
| [DataLimitInMegabytes](dataplanstatus_datalimitinmegabytes.md) | Plan cap (nullable). Null => unspecified limit (do not assume unlimited). |
| [MaxTransferSizeInMegabytes](dataplanstatus_maxtransfersizeinmegabytes.md) | Recommended maximum size for a single transfer (chunk large sync into segments). |
| [NextBillingCycle](dataplanstatus_nextbillingcycle.md) | Start of next cycle (nullable). Do not assume calendar month boundaries. |

### Quota logic guidelines
- Interpret `DataPlanUsage` together with `DataLimitInMegabytes`. A missing limit means you cannot enforce a hard cap safely.
- Use both percentage consumed and time remaining before throttling; early-cycle high usage does not always justify restriction.
- Treat missing `DataLimitInMegabytes` as "unspecified" rather than "unlimited".

### Transfer optimization
- Honor `MaxTransferSizeInMegabytes` by batching work into chunks at or below the recommendation.
- For background sync on metered or limited plans, schedule incremental commits instead of monolithic uploads.

### Billing cycle handling
- `NextBillingCycle` may be absent; fall back to rolling usage display without reset logic.
- When present, derive remaining quota window precisely; operators define custom cycle boundaries.

### Fallback behavior
If `DataPlanStatus` is null or critical fields are missing:
- Present generic usage UI without enforcement.
- Allow user override for "treat as metered" or "treat as unrestricted" preferences if your app supports it.

> [!NOTE]
> Defensive coding: Providers can report unexpected values (like zero or very small `MaxTransferSizeInMegabytes`). Clamp
> to sensible minimums before applying heuristics.


### Null handling
> [!IMPORTANT]  
> Always null‑check the returned **DataPlanStatus**. Some profiles (for example unmanaged Wi‑Fi hotspots) do not expose
> plan information and return null.

### Core elements
| Property | Meaning / Guidance |
| -- | -- |
| [DataPlanUsage](dataplanusage.md) | Current measured usage (may lag real traffic) |
| DataLimitInMegabytes | Plan cap (nullable). Null => unspecified limit (do not assume unlimited) |
| MaxTransferSizeInMegabytes | Recommended maximum size for a single transfer (chunk large sync into segments) |
| NextBillingCycle | Start of next cycle (nullable). Do not assume calendar month boundaries |

### Quota logic guidelines
- Interpret **DataPlanUsage** together with **DataLimitInMegabytes**. A missing limit means you cannot enforce a hard cap safely.
- Use both percentage consumed and time remaining before throttling; early-cycle high usage does not always justify restriction.
- Treat missing **DataLimitInMegabytes** as "unspecified" rather than "unlimited".

### Transfer optimization
- Honor **MaxTransferSizeInMegabytes** by batching work into chunks at or below the recommendation.
- For background sync on metered or limited plans, schedule incremental commits instead of monolithic uploads.

### Billing cycle handling
- **NextBillingCycle** may be absent; fall back to rolling usage display without reset logic.
- When present, derive remaining quota window precisely; operators define custom cycle boundaries.

### Fallback behavior
If **DataPlanStatus** is null or critical fields are missing:
- Present generic usage UI without enforcement.
- Allow user override for "treat as metered" or "treat as unrestricted" preferences if your app supports it.

> [!NOTE]  
> Defensive coding: Providers can report unexpected values (like zero or very small **MaxTransferSizeInMegabytes**). Clamp
> to sensible minimums before applying heuristics.


## -examples
### Example (C#):

```csharp
var profile = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
var status = profile?.GetDataPlanStatus();
if (status?.DataPlanUsage != null && status.DataLimitInMegabytes.HasValue)
{
    var used = status.DataPlanUsage.MegabytesUsed;
    var limit = status.DataLimitInMegabytes.Value;
    double pct = (double)used / limit;
    if (pct > 0.8)
    {
        // Enter reduced bandwidth mode.
    }
}
```

### Example (C++/WinRT):

```cpp
auto profile = Windows::Networking::Connectivity::NetworkInformation::GetInternetConnectionProfile();
auto status = profile ? profile.GetDataPlanStatus() : nullptr;
if (!status)
{
    return; // No data plan info available.
}

auto usage    = status.DataPlanUsage();            // May be null
auto limitRef = status.DataLimitInMegabytes();     // IReference<uint32_t>, may be null

if (usage && limitRef)
{
    auto limit = limitRef.Value();
    if (limit > 0) // Defensive: avoid divide-by-zero if a provider reports 0.
    {
        double pct = static_cast<double>(usage.MegabytesUsed()) / limit;
        if (pct > 0.8)
        {
            // Enter reduced bandwidth mode
        }
    }
}
```

## -see-also

[ConnectionProfile](connectionprofile.md),
[ConnectionProfile.GetConnectionCost](connectionprofile_getconnectioncost_2051899034.md),
[NetworkConnectivity sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/NetworkConnectivity)
