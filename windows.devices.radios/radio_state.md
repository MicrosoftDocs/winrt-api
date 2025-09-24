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
Gets the current operational state of the radio (snapshot at access time).

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

### Programmatic changes
Use [SetStateAsync](radio_setstateasync_1524539262.md) to request On/Off transitions after obtaining permission via
[RequestAccessAsync](radio_requestaccessasync_380675631.md). Confirmation should be based on either the subsequent
[StateChanged](radio_statechanged.md) event or a fresh read of `State`.

> [!NOTE]  
> A result of **Allowed** from [SetStateAsync](radio_setstateasync_1524539262.md) indicates the request was accepted,
> not that the transition completed. Always verify via `State` or the event.

## -examples

## -see-also
[Radio](radio.md),
[Radio.RequestAccessAsync](radio_requestaccessasync_380675631.md),
[Radio.SetStateAsync](radio_setstateasync_1524539262.md),
[Radio.StateChanged](radio_statechanged.md),
[RadioAccessStatus](radioaccessstatus.md),
[RadioState](radiostate.md)
