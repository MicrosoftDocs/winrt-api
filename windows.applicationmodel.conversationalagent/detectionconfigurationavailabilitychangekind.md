---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.DetectionConfigurationAvailabilityChangeKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum DetectionConfigurationAvailabilityChangeKind : int 
-->

# Windows.ApplicationModel.ConversationalAgent.DetectionConfigurationAvailabilityChangeKind

## -description

Specifies the permission levels granted by a user to each [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) of an [ActivationSignalDetector](activationsignaldetector.md).

## -enum-fields

### -field SystemResourceAccess:0

Indicates that a configuration permission to access necessary system resources, such as signal model files, has changed.

### -field Permission:1

Indicates that a configuration permission has changed.

### -field LockScreenPermission:2

Indicates that a configuration permission used above the lock screen has changed.

## -remarks

## -see-also

[DetectionConfigurationAvailabilityChangedEventArgs.Kind](detectionconfigurationavailabilitychangedeventargs_kind.md), [HasLockScreenPermission](detectionconfigurationavailabilityinfo_haslockscreenpermission.md), [HasPermission](detectionconfigurationavailabilityinfo_haspermission.md), [HasSystemResourceAccess](detectionconfigurationavailabilityinfo_hassystemresourceaccess.md)

## -examples
