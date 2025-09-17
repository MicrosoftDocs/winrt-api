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

## -examples
This method returns per‑application (or attribution bucket) usage over the specified window.

Behavioral notes:

* An empty list is a valid outcome (no recorded usage in the interval or provider not available).
* Attribution identifiers may represent apps, system buckets, or aggregated service usage. System / service usage may be combined when detailed separation is not available.
* Time boundaries and partial final intervals follow the same rules as `GetNetworkUsageAsync`.
* Data is subject to accounting latency and should not be used for real‑time enforcement.
* Filtering via `NetworkUsageStates` should be applied sparingly; over‑constraining (e.g., forcing a roaming state) can hide legitimate usage.
* Do not assume stability of attribution identifiers across device resets or provisioning changes.

## -see-also

## -capabilities
networkDataPlanProvisioning
