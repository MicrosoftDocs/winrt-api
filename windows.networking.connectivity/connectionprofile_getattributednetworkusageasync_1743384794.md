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
This method returns per-application (or attribution bucket) usage over the specified window.

For general usage API best practices (time window management, incremental collection, avoiding double counting), see [GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md).

### Attribution-Specific Considerations:

**Data Completeness:**
* Empty result: Valid when no usage is recorded or attribution data is unavailable.
* Aggregate reconciliation: Summing all attributed usage entries may not exactly equal the aggregate usage returned by [GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md); some traffic can reside in non-attributed or system buckets.
* Residual usage: Treat (aggregate - sum(attributed)) as a separate logical bucket if you need a complete picture; do not force attribution of those bytes retroactively.

**Attribution Stability:**
* Attribution identifiers can change across resets or provisioning changes; avoid treating them as permanent keys.
* Identifier churn: Implement a mapping layer so if an AttributionId disappears you can finalize its prior totals without assuming deletion implies uninstall.

**Reconciliation:**
* Double counting avoidance: When reconciling, compute deltas per AttributionId between the last committed snapshot and the new snapshot of the same closed bucket range.
* Apply the same incremental collection patterns as [GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md), but track per-attribution totals.

**Attribution-Aggregate Reconciliation Workflow:**

1. Query aggregate ([GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md)) and attributed ([GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md)) for the same aligned window.
2. Compute per-id deltas since the previous snapshot for fully closed buckets only.
3. Sum attributed totals; compute residual = aggregateTotal - attributedTotal (if positive) and track it under an internal "unattributed" key.
4. Persist updated per-id cumulative totals and new cursor boundary.
5. Periodically (e.g., hourly) re-query the most recent closed bucket to adjust for late provider accounting; apply only positive deltas.

This pattern yields stable cumulative accounting without retroactive double counting and gracefully handles late adjustments and identifier changes.

## -examples

## -see-also

## -capabilities
networkDataPlanProvisioning
