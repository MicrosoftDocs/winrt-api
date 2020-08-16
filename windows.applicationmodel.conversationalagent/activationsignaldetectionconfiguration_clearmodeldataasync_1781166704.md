---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ClearModelDataAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction ActivationSignalDetectionConfiguration.ClearModelDataAsync()
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ClearModelDataAsync

## -description

Asynchronously deletes all model data for the digital assistant.

## -returns

Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.  

## -see-also

## -examples
