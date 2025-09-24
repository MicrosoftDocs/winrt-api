---
-api-id: T:Windows.Networking.Connectivity.ConnectionCost
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectionCost : Windows.Networking.Connectivity.IConnectionCost, Windows.Networking.Connectivity.IConnectionCost2
-->

# Windows.Networking.Connectivity.ConnectionCost

## -description
Exposes cost and data plan constraint information for a network connection so apps can adapt data usage behavior.

## -remarks
[ConnectionCost](connectioncost.md) instances come from  
[ConnectionProfile.GetConnectionCost](connectionprofile_getconnectioncost_2051899034.md). They describe cost policies,  
roaming state, plan limits, and background restrictions so applications can adjust transfer strategies.

### Key properties

**Core cost indicators:**
- **[NetworkCostType](connectioncost_networkcosttype.md)**: Unrestricted, Fixed, or Variable plan classification
- **[Roaming](connectioncost_roaming.md)**: Connection currently incurring roaming charges
- **[OverDataLimit](connectioncost_overdatalimit.md)**: Plan cap exceeded
- **[ApproachingDataLimit](connectioncost_approachingdatalimit.md)**: Nearing plan cap

**Background restriction:**
- **[BackgroundDataUsageRestricted](connectioncost_backgrounddatausagerestricted.md)**: Background transfers limited by
  policy or settings

> [!IMPORTANT]  
> Always evaluate cost properties before large or background transfers. Respecting constraints preserves user data
> allowances and improves experience.

### Adaptive behavior patterns

| Condition | Recommended strategy |
| -- | -- |
| Unrestricted | Full-fidelity sync, media prefetch, normal background work |
| Fixed | Regular operations; gate large optional downloads (offer user confirmation) |
| Variable | Minimize non‑essential transfers; compress & batch user‑initiated large tasks |
| ApproachingDataLimit | Warn before large downloads; lower streaming bitrate / quality |
| OverDataLimit | Pause non‑critical background sync; require explicit user action for large transfers |
| Roaming | Suppress large automatic updates; prefer incremental / compressed payloads |
| BackgroundDataUsageRestricted | Restrict background-only telemetry & sync; allow user foreground actions |
| Roaming + Variable/Fixed | Strict throttling; surface lightweight usage indicator |

### Implementation notes
- Evaluate individual flags; do not rely solely on [NetworkCostType](connectioncost_networkcosttype.md) transitions.
- Re-check cost just before initiating sizable transfers (state can change mid-session).
- Prefer incremental chunking (smaller segments respect shifting policy constraints).

## -examples

## -see-also
[ConnectionProfile.GetConnectionCost](connectionprofile_getconnectioncost_2051899034.md),
[DataPlanStatus](dataplanstatus.md),
[NetworkCostType](networkcosttype.md),
[NetworkInformation](networkinformation.md)
