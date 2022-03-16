---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.GetNetworkUsageAsync(Windows.Foundation.DateTime,Windows.Foundation.DateTime,Windows.Networking.Connectivity.DataUsageGranularity,Windows.Networking.Connectivity.NetworkUsageStates)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.NetworkUsage>> GetNetworkUsageAsync(Windows.Foundation.DateTime startTime, Windows.Foundation.DateTime endTime, Windows.Networking.Connectivity.DataUsageGranularity granularity, Windows.Networking.Connectivity.NetworkUsageStates states)
-->

# Windows.Networking.Connectivity.ConnectionProfile.GetNetworkUsageAsync

## -description
Gets a list of the estimated data traffic and connection duration over a specified period of time, for a specific network usage state.

[DataUsageGranularity](datausagegranularity.md) is used to indicate the desired granularity of the returned data and affects the length of the returned list. [NetworkUsageStates](networkusagestates.md) is used to indicate the desired network usage configuration.

## -parameters

### -param startTime
The start time over which to retrieve data. Can be no more than 60 days prior to the current time. If the specified *granularity* is PerMinute, then the start time can be no more than 120 minutes prior to the current time.

### -param endTime
The end time over which to retrieve data.
This time must be later than the startTime.

### -param granularity
The desired granularity of the returned usage statistics. Each elements in the list corresponds to the network usage per the specified granularity; for example, usage per hour.

### -param states
The state of the connection profile for which usage data should be returned.

## -returns
When the method completes, it returns a list of [NetworkUsage](networkusage.md) objects, which indicate the sent and received values, in bytes, and the total amount of time the profile was connected during the corresponding time interval.
The entries are in chronological order, starting at the startTime.
If the time span is not an exact multiple of the granularity, then the last entry will report usage only up to the endTime.

## -remarks
For an example of how these methods are used, see [How to retrieve connection usage data for a specific period of time](/previous-versions/windows/apps/hh465162(v=win.10)).

## -examples

## -see-also
[DataUsageGranularity](datausagegranularity.md), [NetworkUsage](networkusage.md), [NetworkUsageStates](networkusagestates.md)
