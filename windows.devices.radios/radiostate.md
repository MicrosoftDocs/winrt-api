---
-api-id: T:Windows.Devices.Radios.RadioState
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Radios.RadioState : int
-->

# RadioState

## -description
Defines the operational states of a radio (power and controllability).

## -enum-fields
### -field Unknown:0
The radio state is unknown, or the radio is in a bad or uncontrollable state. Typically represents transient 
hardware conditions or driver initialization states that resolve automatically.

### -field On:1
The radio is powered on.

### -field Off:2
The radio is powered off.

### -field Disabled:3
The radio is powered off and disabled by the device firmware or a hardware switch on the device. Cannot be changed 
programmatically.

## -remarks
Hardware switches or system policy can force **Disabled** regardless of prior requests. **Unknown** typically clears 
after hardware/driver stabilization; re-read state after [StateChanged](radio_statechanged.md) events.

## -examples

## -see-also
[Radio](radio.md),
[Radio.SetStateAsync](radio_setstateasync_1524539262.md),
[Radio.StateChanged](radio_statechanged.md),
[RadioAccessStatus](radioaccessstatus.md)
