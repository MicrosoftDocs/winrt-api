---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.RemoveConfiguration(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public void ActivationSignalDetector.RemoveConfiguration(String signalId, String modelId)
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.RemoveConfiguration

## -description

Removes the ActivationSignalDetectionConfiguration identified by the [ActivationSignalDetectionConfiguration.SignalId](activationsignaldetectionconfiguration_signalid.md) and [ActivationSignalDetectionConfiguration.ModelId](activationsignaldetectionconfiguration_modelid.md) pair.

> [!Important]
> To avoid possible concurrency issues, we recommend using [RemoveConfigurationAsync](activationsignaldetector_removeconfigurationasync_1419607809.md) instead.

## -parameters

### -param signalId

The unique identifier for the [ConversationalAgentSignal](conversationalagentsignal.md).

### -param modelId

The unique model identifier of the [Signal](conversationalagentsignal.md) that activated the conversational agent.

## -remarks

## -see-also

[RemoveConfigurationAsync](activationsignaldetector_removeconfigurationasync_1419607809.md)

## -examples
