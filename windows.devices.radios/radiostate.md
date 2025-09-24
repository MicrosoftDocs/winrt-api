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
Enumeration that describes possible radio states.

## -enum-fields
### -field Unknown:0
The radio state is unknown, or the radio is in a bad or uncontrollable state.

### -field On:1
The radio is powered on.

### -field Off:2
The radio is powered off.

### -field Disabled:3
The radio is powered off and disabled by the device firmware or a hardware switch on the device.

## -remarks
[RadioState](radiostate.md) represents the current operational state of a radio device, indicating both power status and 
controllability.

### State meanings and implications

**Operational states:**
- **On**: Radio is powered and operational, can transmit and receive
- **Off**: Radio is powered down but can be turned on programmatically
- **Disabled**: Radio is off due to hardware switch or firmware, cannot be controlled by software

**Special state:**
- **Unknown**: Radio is in an indeterminate state, possibly due to hardware issues or driver problems

### State transitions and control

**Valid state changes:**
- [SetStateAsync](radio_setstateasync_1524539262.md) accepts **On** and **Off** values only
- **Disabled** cannot be set programmatically - indicates hardware-level control
- **Unknown** cannot be set and suggests hardware or driver issues

**State change considerations:**
- State changes are asynchronous and may take time to complete
- Hardware switches can override software state changes
- System policies may block certain transitions
- Some radios may not support all state transitions

> [!IMPORTANT]
> Never attempt to set [RadioState.Disabled](radiostate.md) or [RadioState.Unknown](radiostate.md) through 
> [SetStateAsync](radio_setstateasync_1524539262.md). These states indicate conditions outside of software control.

## -examples

## -see-also
[Radio](radio.md),
[Radio.SetStateAsync](radio_setstateasync_1524539262.md),
[Radio.StateChanged](radio_statechanged.md),
[RadioAccessStatus](radioaccessstatus.md)