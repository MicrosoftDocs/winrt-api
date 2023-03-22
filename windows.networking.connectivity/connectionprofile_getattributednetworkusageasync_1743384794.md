---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.GetAttributedNetworkUsageAsync(Windows.Foundation.DateTime,Windows.Foundation.DateTime,Windows.Networking.Connectivity.NetworkUsageStates)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.AttributedNetworkUsage>> GetAttributedNetworkUsageAsync(Windows.Foundation.DateTime startTime, Windows.Foundation.DateTime endTime, Windows.Networking.Connectivity.NetworkUsageStates states)
-->

# Windows.Networking.Connectivity.ConnectionProfile.GetAttributedNetworkUsageAsync

## -description
Gets network usage data for each individual application.

## -parameters
### -param startTime
The start time of the usage window.

### -param endTime
The end time of the usage window.

### -param states
The state of the connection profile for which usage data should be returned.

## -returns
When the method completes, it returns a list of [AttributedNetworkUsage](attributednetworkusage.md) objects, which indicate the sent and received values, in bytes, and the total amount of time the app was connected during the corresponding time interval.

## -remarks
> [!NOTE]
> Data usage tracking is not supported when an app is run on the emulator under Microsoft Visual Studio 2013 Update 2 instead of an actual device. As a result, the GetAttributedNetworkUsageAsync method in a Windows Phone 8.x app will fail when run on the emulator.

## -examples

## -see-also


## -capabilities
networkDataPlanProvisioning
