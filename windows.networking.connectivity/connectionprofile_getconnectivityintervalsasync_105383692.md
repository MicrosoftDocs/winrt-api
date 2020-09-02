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
For an example of how these methods are used, see [How to retrieve connection usage data for a specific period of time](/previous-versions/windows/apps/hh465162(v=win.10))

## -examples

## -see-also
