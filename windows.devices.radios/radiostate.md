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
The radio state is unknown, or the radio is in a bad or uncontrollable state.

### -field On:1
The radio is powered on.

### -field Off:2
The radio is powered off.

### -field Disabled:3
The radio is powered off and disabled by the device firmware or a hardware switch on the device.

## -remarks
[RadioState](radiostate.md) combines power and control status. Only **On** and **Off** are transition targets; **Disabled**
and **Unknown** indicate conditions outside app control.

### Meaning summary
| State | Meaning | Controllable via SetStateAsync |
| -- | -- | -- |
| On | Powered and operational | Yes (to Off) |
| Off | Powered down, available for activation | Yes (to On) |
| Disabled | Forced off (hardware switch / firmware / policy) | No |
| Unknown | Indeterminate / error / transient hardware condition | No |

### Transition rules
- [SetStateAsync](radio_setstateasync_1524539262.md) accepts only **On** and **Off**.
- Hardware switches or system policy can force **Disabled** regardless of prior request.
- **Unknown** typically clears after hardware/driver stabilization; re-read after [StateChanged](radio_statechanged.md).

> [!IMPORTANT]  
> Do not attempt to "set" **Disabled** or **Unknown**; treat them as diagnostic states and adjust UI accordingly.

### Recommended pattern
Request access, attempt change (if allowed), then confirm new state inside [StateChanged](radio_statechanged.md) rather
than assuming immediate success.

> [!NOTE]  
> Rapid successive state change requests may coalesce; always observe the final reported state.

## -examples

## -see-also
[Radio](radio.md),
[Radio.SetStateAsync](radio_setstateasync_1524539262.md),
[Radio.StateChanged](radio_statechanged.md),
[RadioAccessStatus](radioaccessstatus.md)
