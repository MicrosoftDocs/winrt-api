---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectorKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ActivationSignalDetectorKind : int 
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectorKind

## -description

Specifies the supported [ActivationSignalDetector](activationsignaldetector.md) types.

## -enum-fields

### -field HardwareEvent:2

Activation signal detected from a hardware device such as a keyboard or bluetooth headset.

### -field AudioPattern:0

Audio input has matched a specified pattern (for example, a keyword or "bark detector").

### -field AudioImpulse:1

Audio input has hit a signal threshold (for example, voice activity detection).

## -remarks

## -see-also

[ActivationSignalDetector.Kind](activationsignaldetector_kind.md), [ConversationalAgentSignal.DetectorKind](conversationalagentsignal_detectorkind.md)

## -examples
