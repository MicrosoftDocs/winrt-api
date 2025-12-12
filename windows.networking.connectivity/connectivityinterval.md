---
-api-id: T:Windows.Networking.Connectivity.ConnectivityInterval
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectivityInterval : Windows.Networking.Connectivity.IConnectivityInterval
-->

# Windows.Networking.Connectivity.ConnectivityInterval

## -description
Represents a contiguous connectivity span (start timestamp plus duration) for a connection profile.

## -remarks
### Definition
A `ConnectivityInterval` captures a span during which the interface for a [ConnectionProfile](connectionprofile.md) was
in a connected state.

### Characteristics
- Presence vs. volume: Indicates connectivity existed; does not convey bytes transferred. Pair with
  [GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md) for volume metrics.
- Gaps: Sleep, interface transitions, or disconnections create gaps. Do not assume continuous coverage.
- Partial boundaries: Leading/trailing intervals may be truncated when the query window cuts through an active
  connection.
- Coalescing: Very brief disconnects may be hidden by higher-level accounting; sub-second precision should not be
  assumed.
- History limits: Subject to the same retention constraints as usage APIs (for example, ~60 days).

### Typical workflow
1. Query intervals with [GetConnectivityIntervalsAsync](connectionprofile_getconnectivityintervalsasync_105383692.md) by supplying start, end, and states values.
2. (Optional) Query usage over the same window.
3. Correlate intervals and usage buckets to derive connected-but-idle versus active transfer periods.

### Edge cases
| Case | Interpretation |
| -- | -- |
| Empty list | No recorded connectivity in window (not an error) |
| Overlapping stitched windows | Deduplicate by interval start time when merging |
| Long active interval | May span entire query window; still valid |

### Incremental collection
Persist the end timestamp of the last fully closed interval. On the next run, start from that point to avoid recounting
an interval still in progress.

### Performance
Summarize promptly. Retaining large raw lists offers little value after computing aggregate connected duration or
utilization.

> [!NOTE]
> To compute utilization, sum `ConnectionDuration` across intervals and divide by total wall-clock span, then overlay
> usage to calculate bytes per connected minute.


## -examples
Enumerate recent connectivity intervals (C#):

```csharp
var profile = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
if (profile != null)
{
    var end = DateTime.UtcNow;
    var start = end - TimeSpan.FromHours(6);
    var states = new Windows.Networking.Connectivity.NetworkUsageStates(); // unconstrained
    var intervals = await profile.GetConnectivityIntervalsAsync(start, end, states);
    foreach (var iv in intervals)
    {
        // iv.StartTime; iv.ConnectionDuration
    }
}
```

## -see-also

[ConnectivityInterval.ConnectionDuration](connectivityinterval_connectionduration.md),
[ConnectivityInterval.StartTime](connectivityinterval_starttime.md)
