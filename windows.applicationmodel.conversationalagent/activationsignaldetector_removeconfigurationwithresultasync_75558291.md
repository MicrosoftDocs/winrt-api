---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.RemoveConfigurationWithResultAsync(System.String,System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.RemoveConfigurationWithResultAsync(System.String,System.String)

<!--
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationRemovalResult> RemoveConfigurationWithResultAsync (string signalId, string modelId);
-->

## -description

Asynchronously removes the ActivationSignalDetectionConfiguration identified by the [ActivationSignalDetectionConfiguration.SignalId](activationsignaldetectionconfiguration_signalid.md) and [ActivationSignalDetectionConfiguration.ModelId](activationsignaldetectionconfiguration_modelid.md) pair, and returns an indicator of success.

## -parameters

### -param signalId

The unique identifier for the [ConversationalAgentSignal](conversationalagentsignal.md).

### -param modelId

The unique model identifier of the [Signal](conversationalagentsignal.md) that activated the conversational agent.

## -returns

Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks

## -see-also

[RemoveConfigurationWithResult(System.String,System.String)](activationsignaldetector_removeconfigurationwithresult_1612836152.md)

## -examples
