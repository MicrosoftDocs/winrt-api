---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.GetProviderNetworkUsageAsync(Windows.Foundation.DateTime,Windows.Foundation.DateTime,Windows.Networking.Connectivity.NetworkUsageStates)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ProviderNetworkUsage>> ConnectionProfile.GetProviderNetworkUsageAsync(DateTime startTime, DateTime endTime, NetworkUsageStates states)
-->

# Windows.Networking.Connectivity.ConnectionProfile.GetProviderNetworkUsageAsync

## -description
Returns the bytes sent and bytes received for each MCC and MNC combination (the combination is represented by a [ProviderId](providernetworkusage_providerid.md)). 

## -parameters

### -param startTime
The start time over which to retrieve data. Can be no more than 60 days prior to the current time.

### -param endTime
The end time over which to retrieve data.

### -param states
The state of the connection profile for which usage data should be returned.

## -returns
Returns a single object containing the bytes send and bytes received for the [ProviderId](providernetworkusage_providerid.md).

## -examples

## -remarks

## -see-also
[ConnectionProfile](connectionprofile.md), [ProviderId](providernetworkusage_providerid.md)
