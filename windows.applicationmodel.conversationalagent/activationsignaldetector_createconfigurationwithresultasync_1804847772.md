---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.CreateConfigurationWithResultAsync(System.String,System.String,System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.CreateConfigurationWithResultAsync(System.String,System.String,System.String)

<!--
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationCreationResult> CreateConfigurationWithResultAsync (string signalId, string modelId, string displayName);
-->

## -description

Aynchronously creates an [ActivationSignalDetectionConfigurationCreationResult](activationsignaldetectionconfigurationcreationresult.md) object associated with the specified [ActivationSignalDetectionConfiguration.SignalId](activationsignaldetectionconfiguration_signalid.md) and [ActivationSignalDetectionConfiguration.ModelId](activationsignaldetectionconfiguration_modelid.md) pair, adds it to the collection of supported configurations for the detector, along with an indicator of success.

## -parameters

### -param signalId

The locale-independent identifier for this configuration.

### -param modelId

The unique identifier, typically locale-specific, for the model data associated with this configuration.

### -param displayName

The name of the signal in a localizable, human-readable form.

## -returns

Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks

## -see-also

[CreateConfigurationWithResult(System.String,System.String,System.String)](activationsignaldetector_createconfigurationwithresult_83010423.md)

## -examples
