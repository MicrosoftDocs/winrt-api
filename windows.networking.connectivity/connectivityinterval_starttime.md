---
-api-id: P:Windows.Networking.Connectivity.ConnectivityInterval.StartTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime StartTime { get; }
-->

# Windows.Networking.Connectivity.ConnectivityInterval.StartTime

## -description
Start timestamp of this connectivity interval.

## -property-value
A `DateTime` (UTC) marking when the interval began. If the query window starts mid‑interval this value can precede the
window's start; the returned duration will be truncated accordingly.

## -remarks
### Notes
- Pairs with [ConnectivityInterval.ConnectionDuration](connectivityinterval_connectionduration.md) to define the full span.
- Represents the moment the interface entered a connected state for this contiguous interval.
- May lie earlier than the query's `startTime` if the interval was already in progress (truncation scenario).
- Use together with successive intervals to reconstruct a connectivity timeline and detect gaps (offline / transition periods).
- For incremental processing, advance a cursor using `StartTime + ConnectionDuration` of the last fully closed interval.

> [!TIP]  
> When stitching results from overlapping queries, de‑duplicate intervals by `StartTime`.

## -examples
Enumerate recent interval start times (C#):

```csharp
var profile = Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile();
if (profile != null)
{
    var end = DateTime.UtcNow;
    var start = end - TimeSpan.FromHours(2);
    var states = new Windows.Networking.Connectivity.NetworkUsageStates(); // unconstrained
    var intervals = await profile.GetConnectivityIntervalsAsync(start, end, states);

    foreach (var iv in intervals)
    {
        DateTimeOffset intervalStart = iv.StartTime;
        var duration = iv.ConnectionDuration;
        // Process interval (intervalStart .. intervalStart + duration)
    }
}
```

## -see-also
