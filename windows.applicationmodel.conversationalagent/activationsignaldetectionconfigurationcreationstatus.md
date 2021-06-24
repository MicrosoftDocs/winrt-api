---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationCreationStatus
-api-type: winrt enum
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationCreationStatus

<!--
public enum ActivationSignalDetectionConfigurationCreationStatus
-->

## -description

Specifies the possible results when creating an [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) for the digital assistant.

## -enum-fields

### -field Success: 0

The [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) was successfully created.

### -field SignalIdNotAvailable: 1

Creation failed because a [SignalId](activationsignaldetectionconfiguration_signalid.md) was not available. This can occur when the signal ID is already associated with an [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md).

### -field ModelIdNotSupported: 2

Creation failed because the specified [ModelId](activationsignaldetectionconfiguration_modelid.md) is not supported by the [ActivationSignalDetector](activationsignaldetector.md).

### -field InvalidSignalId: 3

Creation failed because the specified [SignalId](activationsignaldetectionconfiguration_signalid.md)  is not in the correct format.

### -field InvalidModelId: 4

Creation failed because the specified [ModelId](activationsignaldetectionconfiguration_modelid.md) is not in the correct format.

### -field InvalidDisplayName: 5

Creation failed because the specified [DisplayName](activationsignaldetectionconfiguration_displayname.md) is not in the correct format.

### -field ConfigurationAlreadyExists: 6

Creation failed because [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) already exists.

### -field CreationNotSupported: 7

Creation of an [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) is not supported.

## -remarks

## -see-also

[ActivationSignalDetectionConfigurationCreationResult.Status](activationsignaldetectionconfigurationcreationresult_status.md)

## -examples
