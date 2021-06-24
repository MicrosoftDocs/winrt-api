---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.CreateConfigurationWithResult(System.String,System.String,System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.CreateConfigurationWithResult(System.String,System.String,System.String)

<!--
public Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationCreationResult CreateConfigurationWithResult (string signalId, string modelId, string displayName);
-->

## -description

Creates an [ActivationSignalDetectionConfigurationCreationResult](activationsignaldetectionconfigurationcreationresult.md) object associated with the specified [ActivationSignalDetectionConfiguration.SignalId](activationsignaldetectionconfiguration_signalid.md) and [ActivationSignalDetectionConfiguration.ModelId](activationsignaldetectionconfiguration_modelid.md) pair, adds it to the collection of supported configurations for the detector, along with an indicator of success.

> [!Important]
> To avoid possible concurrency issues, we recommend using [CreateConfigurationWithResultAsync(System.String,System.String,System.String)](activationsignaldetector_createconfigurationwithresultasync_1804847772.md) instead.

## -parameters

### -param signalId

The locale-independent identifier for this configuration.

### -param modelId

The unique identifier, typically locale-specific, for the model data associated with this configuration.

### -param displayName

The name of the signal in a localizable, human-readable form.

## -returns

An object that provides the configuration and the status of the configuration.

## -remarks

## -see-also

[CreateConfigurationWithResultAsync(System.String,System.String,System.String)](activationsignaldetector_createconfigurationwithresultasync_1804847772.md)

## -examples
