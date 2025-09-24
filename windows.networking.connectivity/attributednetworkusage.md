---
-api-id: T:Windows.Networking.Connectivity.AttributedNetworkUsage
-api-type: winrt class
---

<!-- Class syntax.
public class AttributedNetworkUsage : Windows.Networking.Connectivity.IAttributedNetworkUsage
-->

# Windows.Networking.Connectivity.AttributedNetworkUsage

## -description
Represents per-attribution usage statistics (bytes sent, bytes received, connected duration) returned by
[ConnectionProfile.GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md).

## -remarks
### Retrieval
Instances are produced by calling
[ConnectionProfile.GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md) on a
[ConnectionProfile](connectionprofile.md) for a specified time window.

### Attribution identity
- `AttributionId` can represent an app, a system/service bucket, or an aggregated classification.
- Absence of an expected id in a window means no recorded usage (not necessarily uninstalled).

### Data characteristics
- Values are aggregated for the requested window; not real-time counters (provider accounting latency applies).
- Some buckets may report only sent or only received bytes; zeros are valid.
- A trailing partial interval (window ends mid-granularity) is provisional; values may grow on later queries.

### Residual / unattributed usage
The difference between aggregate usage (from
[GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md)) and the sum of attributed entries can
represent system, privacy-suppressed, or otherwise unattributed traffic. Treat this as a logical "unattributed" bucket
if full reconciliation is required.

### Identifier stability
Do not treat `AttributionId` as a permanent device-unique key. Rebase mappings after OS upgrade, device reset, or policy
changes.

### Refresh & lifetime
Re-query when fresh numbers are needed; avoid holding instances long term. Use incremental collection patterns (closed
bucket cursor) similar to aggregate usage.

### Reconciliation & late adjustments
Periodically re-query the most recent closed bucket(s) to pick up late accounting changes. Apply positive deltas only
to your stored cumulative totals rather than overwriting historical values.

> [!NOTE]  
> Summed attributed usage may be less than (or equal to) aggregate usage; do not inflate attributed buckets to force
> equality.

### Recommended pattern
1. Query aggregate and attributed usage for the same aligned window.
2. Compute per-id deltas for fully closed buckets.
3. Track residual bytes (aggregate − sum(attributed)) separately.
4. Persist new cursor boundary and cumulative totals.

## -examples

## -see-also
[ConnectionProfile](connectionprofile.md),
[GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md)
