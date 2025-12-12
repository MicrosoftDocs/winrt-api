---
-api-id: P:Windows.Networking.Connectivity.ConnectivityInterval.ConnectionDuration
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan ConnectionDuration { get; }
-->

# Windows.Networking.Connectivity.ConnectivityInterval.ConnectionDuration

## -description
Length of this connectivity interval.

## -property-value
A `Windows.Foundation.TimeSpan` representing how long the interface remained connected during this interval. May be shorter than the
actual live connection if the queried window started or ended mid-interval.

## -remarks
### Notes
- Pair with [ConnectivityInterval.StartTime](connectivityinterval_starttime.md) to identify the full span.
- Does not imply any data transfer; combine with usage buckets from
  [ConnectionProfile.GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md) for volume metrics.
- Can be truncated when your query window (start/end) slices through an active connection.
- Multiple intervals for a profile can have gaps (device sleep, transition, disconnect).
- Summing all `ConnectionDuration` values from a query window yields total connected time; divide by wall-clock span to
  compute utilization.
- For incremental processing, persist the end (`StartTime` + `ConnectionDuration`) of the last fully closed interval and
  resume from there to avoid recounting an interval still in progress.

> [!TIP]
> Treat very short durations (for example a few milliseconds) cautiously - brief disconnect/reconnect events may be
> coalesced by higher level logic and are rarely meaningful for end-user analytics.

## -examples
```csharp
var profile = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
if (profile != null)
{
    var end = DateTime.UtcNow;
    var start = end - TimeSpan.FromHours(1);
    var states = new Windows.Networking.Connectivity.NetworkUsageStates();
    var intervals = await profile.GetConnectivityIntervalsAsync(start, end, states);

    double connectedSeconds = intervals.Sum(iv => iv.ConnectionDuration.TotalSeconds);
    double utilization = connectedSeconds / (end - start).TotalSeconds;
    // utilization now reflects fraction of the hour the interface was connected
}
```

## -see-also

