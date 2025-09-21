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
Obtain an instance using ConnectionProfile.GetDataPlanStatus on a profile returned by NetworkInformation.GetInternetConnectionProfile or FindConnectionProfilesAsync.

Usage guidance:

1. Always null-check the returned DataPlanStatus. Some profiles do not expose plan information (for example unmanaged Wi-Fi hotspots) and will return null.
2. DataPlanUsage and DataLimitInMegabytes should be interpreted together. If DataLimitInMegabytes is null you cannot enforce a hard cap based solely on usage trends.
3. MaxTransferSizeInMegabytes indicates the largest recommended chunk for a single network transfer to avoid excessive metered charges. Respect this when designing background sync logic that can batch work.
4. NextBillingCycle can be null; when present it allows you to compute remaining quota windows. Avoid assuming month boundaries. Operators can define custom cycles.
5. If you are implementing quota warnings, use both usage percentage and time remaining in the cycle to avoid overly aggressive throttling early in the period.
6. If `DataPlanStatus` is null or `DataLimitInMegabytes` is absent, treat the limit as unspecified (neither explicitly limited nor guaranteed unlimited). Avoid inferring an "unlimited" plan from missing values alone.

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
auto usage = (status && status.DataPlanUsage()) ? status.DataPlanUsage() : nullptr;
if (status && usage && status.DataLimitInMegabytes())
{
    auto used = usage.MegabytesUsed();
    auto limit = status.DataLimitInMegabytes().Value();
    double pct = static_cast<double>(used) / limit;
    if (pct > 0.8) {
        // Enter reduced bandwidth mode
    }
}
```

## -see-also
[ConnectionProfile](connectionprofile.md), NetworkInformation.GetInternetConnectionProfile, ConnectionProfile.GetConnectionCost,
[Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10))
