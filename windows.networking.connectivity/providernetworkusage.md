---
-api-id: T:Windows.Networking.Connectivity.ProviderNetworkUsage
-api-type: winrt class
---

<!-- Class syntax.
public class ProviderNetworkUsage 
-->

# Windows.Networking.Connectivity.ProviderNetworkUsage

## -description
Represents per-provider aggregated usage (bytes sent / bytes received) returned by
[ConnectionProfile.GetProviderNetworkUsageAsync](connectionprofile_getprovidernetworkusageasync_1442391607.md).

## -remarks
### Retrieval
Created by calling
[ConnectionProfile.GetProviderNetworkUsageAsync](connectionprofile_getprovidernetworkusageasync_1442391607.md) for a
time window. Each instance aggregates all traffic attributed to a single provider id over that window.

### Properties
- [BytesSent](providernetworkusage_bytessent.md): Total transmitted bytes for the provider.
- [BytesReceived](providernetworkusage_bytesreceived.md): Total received bytes for the provider.
- [ProviderId](providernetworkusage_providerid.md): Provider identifier (may be empty or unavailable on networks that
  do not supply provider metadata).

### Usage considerations
- Not all connection types expose provider information; expect fewer (or zero) entries on unsupported networks.
- Values are aggregated, not live counters; provider accounting latency can delay updates.
- A missing expected provider id in a window usually means zero usage during that span (not necessarily removal).
- When correlating with app / attribution usage, sums will not necessarily align; scopes differ (provider vs app).

### Scenarios
| Scenario | Benefit |
| -- | -- |
| Multi-carrier devices | Compare distribution of traffic across carriers |
| Cost awareness | Identify providers incurring disproportionate usage |
| Analytics | Trend shifts in provider utilization after policy changes |
| Billing reconciliation | Cross-check provider invoices against local accounting |

### Polling guidance
Query at a cadence aligned with your reporting granularity (hourly or longer for most apps). Avoid sub-minute polling - no
additional fidelity and increased power cost.

### Residual / reconciliation
If aggregate profile usage (see
[GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md)) differs from the sum across providers,
treat the delta as unattributed system / non-provider-scoped traffic.

> [!NOTE]
> Provider usage is only returned when provider metadata is available. Always handle an empty result gracefully.

### Recommended pattern
1. Query provider usage and aggregate usage for the same aligned window.
2. Sum per-provider totals; compute residual = aggregate - sum(providers) (if positive).
3. Persist per-provider cumulative totals keyed by ProviderId (with versioning if identifiers can change).
4. Periodically re-query the most recent closed bucket to incorporate late adjustments (apply positive deltas only).

For general incremental and reconciliation patterns, also review
[ConnectionProfile.GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md) guidance.

## -examples

## -see-also

[AttributedNetworkUsage](attributednetworkusage.md),
[GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md),
[NetworkUsage](networkusage.md),
[NetworkUsageStates](networkusagestates.md)
