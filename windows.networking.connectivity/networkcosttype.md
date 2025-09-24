---
-api-id: T:Windows.Networking.Connectivity.NetworkCostType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Connectivity.NetworkCostType : int
-->

# NetworkCostType

## -description
Defines values for cost policies on a network connection.

## -enum-fields
### -field Unknown:0
Cost information is not available.

### -field Unrestricted:1
The connection is unlimited and has unrestricted usage charges and capacity constraints.

### -field Fixed:2
The use of this connection is unrestricted up to a specific limit.

### -field Variable:3
The connection is costed on a per-byte basis.

## -remarks
Use ConnectionProfile.GetConnectionCost to obtain the ConnectionCost object and inspect its properties
(NetworkCostType, Roaming, OverDataLimit, ApproachingDataLimit, BackgroundDataUsageRestricted) before deciding how
aggressively to transfer data. Evaluate flags individually; do not rely solely on NetworkCostType transitions.

Scenario guidance:

1. Unrestricted: Perform full-fidelity sync operations unless Roaming is true (still respect user preferences while
   roaming). BackgroundDataUsageRestricted can still require throttling even if unrestricted.
2. Fixed: Use conservative background transfer sizes; respect MaxTransferSizeInMegabytes if provided via
   DataPlanStatus. Provide progressive disclosure for large optional downloads.
3. Variable: Treat similar to a fixed plan near its limit. Batch opportunistically and give users a deferral option
   for high-volume tasks.
4. ApproachingDataLimit: Preemptively reduce quality (bitrate, resolution) and surface a subtle UI indicator. Offer a
   user override for critical tasks.
5. OverDataLimit: Pause non-essential background sync. Require explicit user action to proceed with large transfers.
6. BackgroundDataUsageRestricted: Defer background-only telemetry or sync; allow user-initiated foreground actions
   with confirmation.
7. Roaming: Avoid silent large downloads; compress or batch where possible even if NetworkCostType is Unrestricted.
8. Streaming / adaptive content: Dynamically target lower initial bitrate and ramp cautiously when any of
   ApproachingDataLimit, OverDataLimit, Roaming, or BackgroundDataUsageRestricted is active.

## -examples
Decision pseudo-logic:

```csharp
var cost = profile.GetConnectionCost();

bool unrestricted = cost.NetworkCostType == NetworkCostType.Unrestricted;

// Base operating mode
if (unrestricted && !cost.Roaming && !cost.BackgroundDataUsageRestricted)
{
   // App-specific: enable high-bandwidth features (e.g., HD media sync)
}
else
{
   // App-specific: enter conservative mode (reduced quality / deferred background work)
}

// Progressive constraints
if (cost.ApproachingDataLimit)
{
   // App-specific: reduce bitrate / quality to stay within plan (e.g., target ~1.5 Mbps)
}

if (cost.OverDataLimit)
{
   // App-specific: pause non-essential background synchronization
}

if (cost.BackgroundDataUsageRestricted)
{
   // App-specific: defer background-only telemetry / analytics
}

if (cost.Roaming)
{
   // App-specific: compress or batch large payload transfers while roaming
}

// Optional: adapt chunk sizing based on plan type
{
   // Evaluate only when needed for this decision branch.
   bool fixedPlan = cost.NetworkCostType == NetworkCostType.Fixed;
   bool variable  = cost.NetworkCostType == NetworkCostType.Variable;
   if (fixedPlan || variable)
   {
      var chunkSizeMb = cost.MaxTransferSizeInMegabytes ?? 8; // choose smaller transfer chunks
      // App-specific: apply chunkSizeMb constraint to large uploads/downloads
   }
}
```

## -see-also
ConnectionProfile.GetConnectionCost, [ConnectionCost](connectioncost.md), [DataPlanStatus](dataplanstatus.md),
[Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10))
