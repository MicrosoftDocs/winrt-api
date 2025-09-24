---
-api-id: P:Windows.Devices.Radios.Radio.State
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Devices.Radios.RadioState State { get; }
-->

# Windows.Devices.Radios.Radio.State

## -description
Gets the current operational state of the radio.

## -property-value
A [RadioState](radiostate.md) value representing the radio's effective state.

## -remarks
### Behavior
The property reports the current effective (observable) state. Intermediate transitions may be coalesced—only the
final settled state is typically visible.

### Independence
A radio's state is independent of other radio technologies. For example, turning Wi‑Fi off does not imply Bluetooth
or mobile broadband states change.

### Refresh strategy
Do not poll repeatedly. Subscribe to [StateChanged](radio_statechanged.md) and read `State` inside the event handler
to obtain the updated value after a change request or external transition.

## -examples

## -see-also
[Radio](radio.md),
[Radio.RequestAccessAsync](radio_requestaccessasync_380675631.md),
[Radio.SetStateAsync](radio_setstateasync_1524539262.md),
[Radio.StateChanged](radio_statechanged.md),
[RadioAccessStatus](radioaccessstatus.md),
[RadioState](radiostate.md)
