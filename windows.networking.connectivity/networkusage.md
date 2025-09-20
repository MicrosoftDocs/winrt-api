---
-api-id: T:Windows.Networking.Connectivity.NetworkUsage
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkUsage : Windows.Networking.Connectivity.INetworkUsage
-->

# Windows.Networking.Connectivity.NetworkUsage

## -description
Represents network usage statistics returned by the [ConnectionProfile](connectionprofile.md).[GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md) method.

## -remarks
Each `NetworkUsage` entry represents aggregated usage over a contiguous interval defined by the granularity supplied to `ConnectionProfile.GetNetworkUsageAsync`.

Usage considerations:

* Sequence: Entries are chronological; the last entry may be a partial interval if the span does not align with the granularity.
* Sparsity: Zero-traffic intervals might be omitted depending on provider data—do not assume a perfectly dense series.
* Estimation: Byte counts reflect accounting latency; avoid sub-minute enforcement decisions.
* Empty list: Interpret as “no data recorded” for the window, not an error; retry later or widen the interval as needed.
* Aggregation: Sum BytesSent and BytesReceived (use 64-bit arithmetic) across entries for totals; discard large raw lists once summarized.


## -examples

## -see-also
