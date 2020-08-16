---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.CreateConfigurationAsync(System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction ActivationSignalDetector.CreateConfigurationAsync(String signalId, String modelId, String displayName)
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.CreateConfigurationAsync

## -description

Asynchronously creates an [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) object associated with the specified [ActivationSignalDetectionConfiguration.SignalId](activationsignaldetectionconfiguration_signalid.md) and [ActivationSignalDetectionConfiguration.ModelId](activationsignaldetectionconfiguration_modelid.md) pair and adds it to the collection of supported configurations for the detector.

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

## -examples
