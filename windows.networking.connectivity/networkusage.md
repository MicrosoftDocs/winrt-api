---
-api-id: T:Windows.Networking.Connectivity.NetworkUsage
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkUsage : Windows.Networking.Connectivity.INetworkUsage
-->

# Windows.Networking.Connectivity.NetworkUsage

## -description
Represents network usage statistics returned by the
[ConnectionProfile](connectionprofile.md).[GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md)
method.

## -remarks
Each `NetworkUsage` entry represents aggregated usage over a contiguous interval defined by the granularity supplied
to `ConnectionProfile.GetNetworkUsageAsync`.

Usage considerations:

* Sequence: Entries are chronological; the last entry may be a partial interval if the span does not align with the
	granularity.
* Sparsity: Zero-traffic intervals might be omitted depending on provider data—do not assume a perfectly dense series.
* Estimation: Byte counts reflect accounting latency; avoid sub-minute enforcement decisions.
* Empty list: Interpret as “no data recorded” for the window, not an error; retry later or widen the interval as needed.
* Aggregation: Sum BytesSent and BytesReceived (use 64-bit arithmetic) across entries for totals; discard large raw
	lists once summarized.
* Partial trailing interval: If the requested end time falls inside a granularity bucket, that bucket’s values are
	provisional and may grow—re-query if you need finalized numbers.
* Reconciliation with attributed usage: Summing all [AttributedNetworkUsage](attributednetworkusage.md) entries for the
	same window can be less than or equal to the aggregate from `NetworkUsage`; residual bytes can represent
	un-attributed system activity or accounting alignment.
* Multi-interface scenarios: Query each relevant `ConnectionProfile` separately—this type does not merge across
	interfaces for you. Perform aggregation in your code if you present a holistic device view.
* Sliding cursor collection: Maintain the boundary of the last fully closed bucket (aligned to granularity) and only
	commit complete buckets to avoid double counting when polling.
* Overflow safety: Use checked 64-bit accumulation when summing long historical ranges; do not downcast to 32-bit.


## -examples

## -see-also
