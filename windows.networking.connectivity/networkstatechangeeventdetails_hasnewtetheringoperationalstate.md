---
-api-id: P:Windows.Networking.Connectivity.NetworkStateChangeEventDetails.HasNewTetheringOperationalState
-api-type: winrt property
---

<!-- Property syntax
public bool HasNewTetheringOperationalState { get; }
-->

# Windows.Networking.Connectivity.NetworkStateChangeEventDetails.HasNewTetheringOperationalState

## -description
Indicates whether the mobile hotspot (tethering) operational state may have changed for this network status change event.

## -property-value
True if the operational state may have changed; otherwise false. Treat true as a hint to re-query the authoritative tethering manager for the current state.

## -remarks
### Semantics
Signals that the effective tethering (mobile hotspot) operational state (Disabled, Enabling, Enabled/Active, DisabledByPolicy, etc.) may have transitioned.

### Guidance
- Hint, not value: This property does not embed the new state—always re-query
  [NetworkOperatorTetheringManager.TetheringOperationalState](../windows.networking.networkoperators/networkoperatortetheringmanager_tetheringoperationalstate.md).
- Meaningful transitions only: Intermediate internal steps can be coalesced; design UI to tolerate brief indeterminate periods.
- Policy transitions: State can change due to policy / entitlement without user action—listen continuously.
- Duplicate notifications: If re-queried state equals your cached state, treat as benign duplicate.
- Ordering: May fire before or after
  [HasNewTetheringClientCount](networkstatechangeeventdetails_hasnewtetheringclientcount.md); handle independently.
- Failure scenarios: If enable attempt reverts back to Disabled (or policy-disabled), surface the final state to users rather than leaving a perpetual “enabling” indicator.

### Recommended pattern
1. Cache initial state during feature initialization.
2. On status change: if true, re-query operational state.
3. If changed, update UI / telemetry; else ignore.
4. Apply a timeout for “Enabling” -> if exceeded, re-query and reconcile (show failure if reverted).

### Best practices
| Concern | Recommendation |
| -- | -- |
| UI flicker during rapid transitions | Debounce updates (short delay) |
| Power usage | Avoid polling; rely on events |
| Policy override clarity | Distinguish DisabledByPolicy (or equivalent) from user-disabled |
| Logging | Log old -> new state transitions with timestamp for diagnostics |

> [!NOTE]  
> Pair with **HasNewTetheringClientCount** to refresh connected client metrics after confirming tethering remains active.


## -examples
### Example: Reacting to tethering operational state changes (C#)
```csharp
NetworkInformation.NetworkStatusChanged += (s) =>
{
    var evt = NetworkInformation.GetNetworkStateChangeEventDetails();
    if (evt?.HasNewTetheringOperationalState == true)
    {
        var profile = NetworkInformation.GetInternetConnectionProfile();
        if (profile == null) return;

        var mgr = Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager
                    .CreateFromConnectionProfile(profile);

        var state = mgr.TetheringOperationalState;
        if (state != _cachedOperationalState)
        {
            var previous = _cachedOperationalState;
            _cachedOperationalState = state;
            UpdateTetheringStateUI(previous, state); // app-specific
        }
    }
};
```

## -see-also
[NetworkStateChangeEventDetails](networkstatechangeeventdetails.md),  
[NetworkStateChangeEventDetails.HasNewTetheringClientCount](networkstatechangeeventdetails_hasnewtetheringclientcount.md),  
[NetworkInformation.NetworkStatusChanged](networkinformation_networkstatuschanged.md)
