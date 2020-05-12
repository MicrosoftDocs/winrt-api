---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ClearTrainingDataAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction ActivationSignalDetectionConfiguration.ClearTrainingDataAsync()
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ClearTrainingDataAsync

## -description

Asynchronously deletes all voice training data from the [ActivationSignalDetector](activationsignaldetector.md) for the digital assistant.

## -returns

Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data. For example, training a spoken keyword detector to only detect the keyword when spoken by a specific person.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.  

## -see-also

## -examples
