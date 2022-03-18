---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectorPowerState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ActivationSignalDetectorPowerState : int 
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectorPowerState

## -description

Specifies the power modes, supported by an [ActivationSignalDetector](activationsignaldetector.md), that describe the power-related conditions under which a detector is allowed to operate.

## -enum-fields

### -field HighPower:0

A device that is not currently affected by any power restriction conditions. For example, a laptop that's charging and in active use (with the screen on).

### -field ConnectedLowPower:1

A device in a low-power state but not currently using battery power. For example, a laptop that's charging while in sleep state.

### -field DisconnectedLowPower:2

A device in a low-power state and using battery power. For example, a laptop in sleep state that's not connected to an external power source.

## -remarks

## -see-also

[ActivationSignalDetector.SupportedPowerStates](activationsignaldetector_supportedpowerstates.md)

## -examples
