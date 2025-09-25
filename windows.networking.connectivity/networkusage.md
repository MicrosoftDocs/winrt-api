---
-api-id: T:Windows.Networking.Connectivity.NetworkUsage
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkUsage : Windows.Networking.Connectivity.INetworkUsage
-->

# Windows.Networking.Connectivity.NetworkUsage

## -description
Represents per-interval network usage statistics returned by
[ConnectionProfile.GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md).

## -remarks
Each **NetworkUsage** entry represents aggregated usage over a contiguous interval defined by the granularity supplied to
**ConnectionProfile.GetNetworkUsageAsync**.

### Usage considerations

* **Sequence**: Entries are chronological; the last entry can be a partial interval if the span does not align with the
  granularity boundary.
* **Sparsity**: Zero‑traffic intervals can be omitted depending on provider data; do not assume a dense, gap‑free time
  series.
* **Estimation latency**: Byte counts can reflect accounting delay; avoid sub‑minute quota or throttling decisions.
* **Empty list**: Interpret as "no recorded usage in window" (not an error). Re-query later or widen the interval.
* **Aggregation**: Sum **BytesSent** + **BytesReceived** (use 64‑bit integers). Discard large raw lists after summarizing to
  reduce memory.
* **Partial trailing interval**: If the end time falls inside an open bucket its values are provisional and may grow;
  re-query later for a finalized total.
* **Reconciliation with attributed usage**: Summed [AttributedNetworkUsage](attributednetworkusage.md) can be less than
  or equal to aggregate **NetworkUsage**; the delta can represent unattributed system traffic or accounting alignment.
* **Multiple profiles**: Query each relevant [ConnectionProfile](connectionprofile.md) separately; this type never
  merges across profiles or interfaces. Aggregate in app code for a device-wide view.
* **Sliding window collection**: Track the last fully closed bucket (aligned to granularity) and only commit closed
  buckets to avoid double counting when polling.
* **Overflow safety**: Use checked 64‑bit accumulation over long historical ranges; never downcast to 32‑bit.

> [!NOTE]  
> Re-query only as often as your granularity justifies. Excessive polling increases power and CPU cost without adding
> accuracy.


## -examples

## -see-also
[AttributedNetworkUsage](attributednetworkusage.md),
[ConnectionProfile](connectionprofile.md),
[ConnectionProfile.GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md)
