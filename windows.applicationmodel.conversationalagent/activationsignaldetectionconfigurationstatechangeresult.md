---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationStateChangeResult
-api-type: winrt enum
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationStateChangeResult

<!--
public enum ActivationSignalDetectionConfigurationStateChangeResult
-->

## -description

Specifies the possible results returned when enabling or disabling [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) for the digital assistant.

## -enum-fields

### -field Success: 0

The state change was successful.

### -field NoModelData: 1

The state change from disabled to enabled failed because the configuration has no model data.

### -field ConfigurationNotFound: 2

The state change failed because the [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) was not found.

## -remarks

## -see-also

[SetEnabledWithResult(System.Boolean)](activationsignaldetectionconfiguration_setenabledwithresult_1176849337.md), [SetEnabledWithResultAsync(System.Boolean)](activationsignaldetectionconfiguration_setenabledwithresultasync_1777466107.md)

## -examples
