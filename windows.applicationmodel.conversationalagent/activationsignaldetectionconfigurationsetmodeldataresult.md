---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationSetModelDataResult
-api-type: winrt enum
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationSetModelDataResult

<!--
public enum ActivationSignalDetectionConfigurationSetModelDataResult
-->

## -description

Specifies the possible results returned when setting the model configuration data of an [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) for the digital assistant.

## -enum-fields

### -field Success: 0

The setting of the model data was successful.

### -field EmptyModelData: 1

No model data available.

### -field UnsupportedFormat: 2

The specified model data format is not recognized.

### -field ConfigurationCurrentlyEnabled: 3

The model data cannot be set because the configuration is currently enabled.

### -field InvalidData: 4

The model data is invalid.

### -field SetModelDataNotSupported: 5

Setting of the model data is not supported by the [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md).

### -field ConfigurationNotFound: 6

The model data was not set because the [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) was not found.

### -field UnknownError: 7

Unexpected error.

## -remarks

## -see-also

[SetModelDataWithResult(System.String,Windows.Storage.Streams.IInputStream)](activationsignaldetectionconfiguration_setmodeldatawithresult_384345367.md), [SetModelDataWithResultAsync(System.String,Windows.Storage.Streams.IInputStream)](activationsignaldetectionconfiguration_setmodeldatawithresultasync_1134103402.md)

## -examples
