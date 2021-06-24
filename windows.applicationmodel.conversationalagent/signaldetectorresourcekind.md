---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.SignalDetectorResourceKind
-api-type: winrt enum
---

# Windows.ApplicationModel.ConversationalAgent.SignalDetectorResourceKind

<!--
public enum SignalDetectorResourceKind
-->

## -description

Specifies the types of system resources that might be reported as unavailable to an [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md).

## -enum-fields

### -field ParallelModelSupport: 0

The number of active, unique models as specified by the [ActivationSignalDetector](activationsignaldetector.md) object has been exceeded.

### -field ParallelModelSupportForAgent: 1

The number of active, unique models as specified by the [ConversationalAgentSession](conversationalagentsession.md) object has been exceeded.

### -field ParallelSignalSupport: 2

The number of active, unique signals as specified by the [ActivationSignalDetector](activationsignaldetector.md) object has been exceeded.

### -field ParallelSignalSupportForAgent: 3

The number of active, unique signals as specified by the [ConversationalAgentSession](conversationalagentsession.md) object has been exceeded.

### -field DisplayOffSupport: 4

The [ActivationSignalDetector](activationsignaldetector.md) object is not active when the display is turned off.

### -field PluggedInPower: 5

The [ActivationSignalDetector](activationsignaldetector.md) object requires the system to be plugged in to external power. The associated detector is not active on battery power.

### -field Detector: 6

The [ActivationSignalDetector](activationsignaldetector.md) object is in an error state and is not currently functional.

### -field SupportedSleepState: 7

The [ActivationSignalDetector](activationsignaldetector.md) object is not active when system is in sleep state.

### -field SupportedBatterySaverState: 8

The [ActivationSignalDetector](activationsignaldetector.md) object is not active in the current battery saver state.

### -field ScreenAvailability: 9

The [ActivationSignalDetector](activationsignaldetector.md) object is not active when the display is unavailable, such as when a laptop lid is closed.

### -field InputHardware: 10

The [ActivationSignalDetector](activationsignaldetector.md) object is not active when there is no suitable hardware available, such as a microphone to detect a spoken keyword. The hardware might be disabled, in error state, or unavailable for some reason.

### -field AcousticEchoCancellation: 11

The [ActivationSignalDetector](activationsignaldetector.md) object requires Acoustic Echo Cancellation (AEC), but AEC is not available or supported.

### -field ModelIdSupport: 12

The specified model ID is not valid for the [ActivationSignalDetector](activationsignaldetector.md) object.

### -field DataChannel: 13

The specified data channel is not valid for the [ActivationSignalDetector](activationsignaldetector.md) object.

## -remarks

## -see-also

[DetectionConfigurationAvailabilityInfo.UnavailableSystemResources](detectionconfigurationavailabilityinfo_unavailablesystemresources.md), [HasSystemResourceAccess](detectionconfigurationavailabilityinfo_hassystemresourceaccess.md)

## -examples
