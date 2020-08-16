---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.GetConfiguration(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public ActivationSignalDetectionConfiguration ActivationSignalDetector.GetConfiguration(String signalId, String modelId)
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.GetConfiguration

## -description

Gets the [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) object associated with the specified [ActivationSignalDetectionConfiguration.SignalId](activationsignaldetectionconfiguration_signalid.md) and [ActivationSignalDetectionConfiguration.ModelId](activationsignaldetectionconfiguration_modelid.md) pair.

> [!Important]
> To avoid possible concurrency issues, we recommend using [GetConfigurationAsync](activationsignaldetector_getconfigurationasync_1120837113.md) instead.

## -parameters

### -param signalId

The unique identifier for the [ConversationalAgentSignal](conversationalagentsignal.md).

### -param modelId

The unique model identifier of the [Signal](conversationalagentsignal.md) that activated the conversational agent.

## -returns

The [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) object associated with the specified [ActivationSignalDetectionConfiguration.SignalId](activationsignaldetectionconfiguration_signalid.md) and [ActivationSignalDetectionConfiguration.ModelId](activationsignaldetectionconfiguration_modelid.md) pair.

## -remarks

## -see-also

[GetConfigurationAsync](activationsignaldetector_getconfigurationasync_1120837113.md)

## -examples
