---
-api-id: T:Windows.Networking.Connectivity.DataPlanStatus
-api-type: winrt class
---

<!-- Class syntax.
public class DataPlanStatus : Windows.Networking.Connectivity.IDataPlanStatus
-->

# Windows.Networking.Connectivity.DataPlanStatus

## -description
Represents the current status information for the data plan associated with a connection.

## -remarks
Obtain an instance using [ConnectionProfile](connectionprofile.md).[GetDataPlanStatus](connectionprofile_getdataplanstatus_1468491499.md) on a profile returned by [NetworkInformation](networkinformation.md).[GetInternetConnectionProfile](networkinformation_getinternetconnectionprofile_1892430619.md), [FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_649346237.md), or [GetConnectionProfiles](networkinformation_getconnectionprofiles_1348266395.md).

Usage guidance:

> [!IMPORTANT]
> Always null-check the returned DataPlanStatus. Some profiles do not expose plan information (for example unmanaged Wi-Fi hotspots) and will return null.

* [DataPlanUsage](dataplanusage.md) and DataLimitInMegabytes should be interpreted together. If DataLimitInMegabytes is null you cannot enforce a hard cap based solely on usage trends.
* MaxTransferSizeInMegabytes indicates the largest recommended chunk for a single network transfer to avoid excessive metered charges. Respect this when designing background sync logic that can batch work.
* NextBillingCycle can be null; when present it allows you to compute remaining quota windows. Avoid assuming month boundaries. Operators can define custom cycles.
* If you are implementing quota warnings, use both usage percentage and time remaining in the cycle to avoid overly aggressive throttling early in the period.
* If `DataPlanStatus` is null or `DataLimitInMegabytes` is absent, treat the limit as unspecified (neither explicitly limited nor guaranteed unlimited). Avoid inferring an "unlimited" plan from missing values alone.

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
[ConnectionProfile.GetConnectionCost](connectionprofile_getconnectioncost_1946735978.md),
[NetworkInformation.GetInternetConnectionProfile](networkinformation_getinternetconnectionprofile_1892430619.md),
[Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10))
