---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationRemovalResult
-api-type: winrt enum
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationRemovalResult

<!--
public enum ActivationSignalDetectionConfigurationRemovalResult
-->

## -description

Specifies the possible results when removing an [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) from the digital assistant.

## -enum-fields

### -field Success: 0

The [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) was successfully removed.

### -field NotFound: 1

Removal failed because the [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) was not found.

### -field CurrentlyEnabled: 2

Removal failed because the [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) is currently enabled.

### -field RemovalNotSupported: 3

Removal failed because removal of the [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) is not supported.

## -remarks

## -see-also

[RemoveConfigurationWithResult(System.String,System.String)](activationsignaldetector_removeconfigurationwithresult_1612836152.md), [RemoveConfigurationWithResultAsync(System.String,System.String)](activationsignaldetector_removeconfigurationwithresultasync_75558291.md)

## -examples
