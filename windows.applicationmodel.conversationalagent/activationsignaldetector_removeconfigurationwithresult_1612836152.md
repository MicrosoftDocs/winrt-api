---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.RemoveConfigurationWithResult(System.String,System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.RemoveConfigurationWithResult(System.String,System.String)

<!--
public Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationRemovalResult RemoveConfigurationWithResult (string signalId, string modelId);
-->

## -description

Removes the ActivationSignalDetectionConfiguration identified by the [ActivationSignalDetectionConfiguration.SignalId](activationsignaldetectionconfiguration_signalid.md) and [ActivationSignalDetectionConfiguration.ModelId](activationsignaldetectionconfiguration_modelid.md) pair, and returns an indicator of success.

> [!Important]
> To avoid possible concurrency issues, we recommend using [RemoveConfigurationWithResultAsync(System.String,System.String)](activationsignaldetector_removeconfigurationwithresultasync_75558291.md) instead.

## -parameters

### -param signalId

The unique identifier for the [ConversationalAgentSignal](conversationalagentsignal.md).

### -param modelId

The unique model identifier of the [Signal](conversationalagentsignal.md) that activated the conversational agent.

## -returns

A value that indicates whether the call succeeded or the reason it failed.

## -remarks

## -see-also

 [RemoveConfigurationWithResultAsync(System.String,System.String)](activationsignaldetector_removeconfigurationwithresultasync_75558291.md)

## -examples
