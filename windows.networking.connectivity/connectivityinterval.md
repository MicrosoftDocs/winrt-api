---
-api-id: T:Windows.Networking.Connectivity.ConnectivityInterval
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ConnectivityInterval : Windows.Networking.Connectivity.IConnectivityInterval
-->

# Windows.Networking.Connectivity.ConnectivityInterval

## -description
Provides the start time and duration for an established or prior connection.

## -remarks
`ConnectivityInterval` represents a contiguous span of time during which the underlying interface associated with a `ConnectionProfile` was in a connected state.

Key characteristics:

* Presence vs traffic: An interval indicates connectivity existed; it does not imply data transfer. Pair with usage APIs (`GetNetworkUsageAsync`) if you need volume metrics.
* Gaps: If the device disconnected, slept, or the interface transitioned, gaps appear between intervals. Do not assume back-to-back coverage of a query window.
* Partial windows: The first or last interval in a query can be truncated if your start or end time falls mid-interval.
* Coalescing: Very brief disconnects may be absorbed by higher layer accounting; avoid relying on sub-second precision.
* Time bounds: Queries (via `GetConnectivityIntervalsAsync`) are subject to the same historical limits as usage APIs (for example 60 days of history).

Common pattern:

1. Call `GetConnectivityIntervalsAsync(start, end, states)` to obtain connected spans.
2. Optionally call `GetNetworkUsageAsync` over the same window.
3. Intersect intervals with usage buckets to compute connected-but-idle time.

Edge cases:

* Empty result set: No connectivity recorded in the window (device offline or history unavailable) — treat as "no data", not failure.
* Overlapping queries: You can stitch results from successive overlapping windows; deduplicate identical tail intervals by start time.

Performance guidance: Summarize or aggregate intervals promptly. Storing large raw lists in memory provides little additional value once summarized.

Functional correlation note: A connectivity interval does not guarantee non-zero data transfer. Zero usage within an interval is valid, and small usage bursts can appear in multiple intervals if the active interface changes.


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
