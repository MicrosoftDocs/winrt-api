---
-api-id: P:Windows.Networking.Connectivity.NetworkStateChangeEventDetails.HasNewTetheringOperationalState
-api-type: winrt property
---

<!-- Property syntax
public bool HasNewTetheringOperationalState { get; }
-->

# Windows.Networking.Connectivity.NetworkStateChangeEventDetails.HasNewTetheringOperationalState

## -description
Gets a value that indicates whether the tethering operational state has changed.

## -property-value
When true, tethering operational state has changed.

## -remarks
Indicates that the effective tethering (mobile hotspot) operational state (for example: disabled, enabling,
enabled/active, disabled by policy) has changed since it was last observed.

Guidance:

* Trigger scope: The flag is raised for meaningful state transitions (for example, enable request accepted, active
  session termination, policy disable). Internal intermediate steps may be coalesced.
* Re-query required: Retrieve the current tethering operational state from the authoritative API after seeing this
  flag; do not infer the new state purely from context.
* Latency: A small delay can exist between low-level adapter changes and the surfaced operational state transition;
  design UI to tolerate brief indeterminate states.
* Policy gating: Transitions caused by policy or entitlement changes can occur without user initiation. Listen
  continuously rather than only after user actions.
* Idempotency: If you re-query and the state equals your cached value, treat it as a benign duplicate notification.
* Sequencing with client count: `HasNewTetheringOperationalState` can appear before or after `HasNewTetheringClientCount`;
  handle them independently and re-query both state and client metrics when each fires.
* Failure handling: If an attempted enable operation results in a transition back to a disabled state, expose the
  final state to the user rather than intermediate enable-in-progress indicators.

Recommended handling pattern:
1. On startup, query and cache current tethering state.
2. On network status change, if `HasNewTetheringOperationalState` is true, re-query state.
3. Update UI / logic only if state changed.
4. If enabling and state stalls in an intermediate value beyond your timeout, re-query; if it reverts, surface failure gracefully.

## -examples
### Example: Reacting to tethering operational state changes (C#)
```csharp
NetworkInformation.NetworkStatusChanged += async (s) =>
{
    var details = NetworkInformation.GetNetworkStateChangeEventDetails();
    if (details?.HasNewTetheringOperationalState == true)
    {
        var newState = await TetheringHelper.GetOperationalStateAsync(); // placeholder call
        if (newState != _cachedState)
        {
            _cachedState = newState;
            UpdateTetheringStateDisplay(newState);
        }
    }
};
```

## -see-also
