---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.GetConnectivityIntervalsAsync(Windows.Foundation.DateTime,Windows.Foundation.DateTime,Windows.Networking.Connectivity.NetworkUsageStates)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.ConnectivityInterval>> GetConnectivityIntervalsAsync(Windows.Foundation.DateTime startTime, Windows.Foundation.DateTime endTime, Windows.Networking.Connectivity.NetworkUsageStates states)
-->

# Windows.Networking.Connectivity.ConnectionProfile.GetConnectivityIntervalsAsync

## -description
Gets a list of [ConnectivityInterval](connectivityinterval.md) objects, which indicate the timestamp for when the network connection began, and a time-span for the duration of that connection.

## -parameters
### -param startTime
The start time over which to retrieve data. Can be no more than 60 days prior to the current time.

### -param endTime
The end time over which to retrieve data.

### -param states
The state of the connection profile for which usage data should be returned.

## -returns
When the method completes, it returns a list of [ConnectivityInterval](connectivityinterval.md) objects, which indicate the start time and duration for the current or prior connections.

## -remarks
Guidance:

* Combine with [GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md) to correlate connected time and transferred bytes. Intervals capture presence; usage captures volume.
* Align query bounds (start/end) with your reporting window. The API can return partial leading or trailing intervals if your bounds cut through an active connection.
* Empty results are valid (no connectivity in that window); treat as "no data" not an error.
* Avoid overly fine periodic polling (e.g., every few seconds). Typical aggregation windows are 15 minutes or larger.
* When computing utilization, sum interval durations and compare to total wall-clock span; derive idle vs active byte density by overlaying usage results.
* Historical limits (e.g., maximum 60 days) mirror usage API constraints; segment longer history queries.

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