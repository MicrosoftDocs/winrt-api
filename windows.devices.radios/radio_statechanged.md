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

### Recommended pattern
1. Read current [Radio.State](radio_state.md) inside the handler (do not rely on cached state).
2. Apply minimal conditional logic (only act when the new state changes app behavior).
3. Queue or dispatch heavier work outside the handler if needed.
4. Unsubscribe (`-=`) when the radio object is no longer required.

## -examples

For complete radio enumeration and state monitoring examples, see [Radio](radio.md).

## -see-also
[Radio](radio.md),
[Radio.State](radio_state.md),
[RadioState](radiostate.md)
