---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.GetConnectivityIntervalsAsync(Windows.Foundation.DateTime,Windows.Foundation.DateTime,Windows.Networking.Connectivity.NetworkUsageStates)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.ConnectivityInterval>> GetConnectivityIntervalsAsync(Windows.Foundation.DateTime startTime, Windows.Foundation.DateTime endTime, Windows.Networking.Connectivity.NetworkUsageStates states)
-->

# Windows.Networking.Connectivity.ConnectionProfile.GetConnectivityIntervalsAsync

## -description
Retrieves connectivity intervals (start timestamp plus duration) for this profile within the specified time window.

## -parameters
### -param startTime
The start time over which to retrieve data. Can be no more than 60 days prior to the current time.

### -param endTime
The end time over which to retrieve data.

### -param states
The state of the connection profile for which usage data should be returned.

## -returns
A list of [ConnectivityInterval](connectivityinterval.md) objects, each providing the connection start time and its duration.

## -remarks
### Usage considerations
* Correlate with [GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md) for volume metrics. Intervals = presence; usage = bytes.
* Align start/end times to reporting boundaries. Leading or trailing partial intervals are returned when the window cuts through an active connection.
* Empty result = no connectivity recorded in the window (not an error).
* Poll no more frequently than needed (typical aggregation windows: ≥ 15 minutes). Very fine polling wastes power.
* Utilization: Sum `ConnectionDuration` across intervals; divide by total wall‑clock span to derive connected ratio. Overlay usage data to compute bytes per connected minute.
* Historical limits (≤ 60 days) mirror usage API limits. Partition longer look‑backs into allowed segments.

> [!NOTE]  
> For incremental collection, persist the end of the last fully closed interval boundary and resume from there to avoid recounting a still-active interval.

## -examples
Example pattern (C#):

```csharp
var profile = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
if (profile != null)
{
    var end = DateTime.UtcNow;
    var start = end - TimeSpan.FromHours(24);
    var states = new Windows.Networking.Connectivity.NetworkUsageStates();
    var intervals = await profile.GetConnectivityIntervalsAsync(start, end, states);
    double connectedMinutes = intervals.Sum(i => i.ConnectionDuration.TotalMinutes);
    // Optionally fetch usage and compute bytes per connected minute
}
```

## -see-also
[How to retrieve connection usage data for a specific period of time](/previous-versions/windows/apps/hh465162(v=win.10))
