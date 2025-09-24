---
-api-id: E:Windows.Devices.Radios.Radio.StateChanged
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler StateChanged<Windows.Devices.Radios.Radio,  object>
-->

# Windows.Devices.Radios.Radio.StateChanged

## -description
Occurs when a radio's operational state changes.

## -remarks
### Overview
Raised for transitions between [RadioState](radiostate.md) values. Lets apps adapt to user or system initiated
changes (power policy, airplane mode, hardware switch, entitlement).

### Threading
Handlers run on a background thread. Marshal to the appropriate app thread for UI or thread-affine operations. Keep
handlers short to avoid delaying subsequent notifications.

### Recommended pattern
1. Read current [Radio.State](radio_state.md) inside the handler (do not rely on cached state).
2. Apply minimal conditional logic (only act when the new state changes app behavior).
3. Queue or dispatch heavier work outside the handler if needed.
4. Unsubscribe (`-=`) when the radio object is no longer required.

### Best practices
| Concern | Guidance |
| -- | -- |
| Missing intermediates | Always treat the observed state as authoritative; do not infer skipped states. |
| Resource leaks | Unsubscribe when disposing long-lived consumers to prevent memory retention. |
| Duplicate subscriptions | Guard against attaching the same handler multiple times. |
| Resilience | Handle every defined [RadioState](radiostate.md) value (including future / unknown) gracefully. |

> [!NOTE]  
> Handlers execute on background threads; marshal only the minimal data needed to the foreground/UI thread.

## -examples

For complete radio enumeration and state monitoring examples, see [Radio class documentation](radio.md).

## -see-also
[Radio](radio.md),
[Radio.State](radio_state.md),
[RadioState](radiostate.md)
