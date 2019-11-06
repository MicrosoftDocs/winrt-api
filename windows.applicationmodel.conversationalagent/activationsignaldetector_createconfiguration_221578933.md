---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.CreateConfiguration(System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public void ActivationSignalDetector.CreateConfiguration(String signalId, String modelId, String displayName)
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.CreateConfiguration

## -description

Creates an [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) object associated with the specified [ActivationSignalDetectionConfiguration.SignalId](activationsignaldetectionconfiguration_signalid.md) and [ActivationSignalDetectionConfiguration.ModelId](activationsignaldetectionconfiguration_modelid.md) pair and adds it to the collection of supported configurations for the detector.

> [!Important]
> To avoid possible concurrency issues, we recommend using [CreateConfigurationAsync](activationsignaldetector_createconfigurationasync_1444114791.md) instead.

## -parameters

### -param signalId

The locale-independent identifier for this configuration.

### -param modelId

The unique identifier, typically locale-specific, for the model data associated with this configuration.

### -param displayName

The name of the signal in a localizable, human-readable form.

## -remarks

## -see-also

[CreateConfigurationAsync](activationsignaldetector_createconfigurationasync_1444114791.md)

## -examples
