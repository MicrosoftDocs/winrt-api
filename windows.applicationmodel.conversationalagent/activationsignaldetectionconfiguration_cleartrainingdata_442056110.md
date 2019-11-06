---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ClearTrainingData
-api-type: winrt method
---

<!-- Method syntax.
public void ActivationSignalDetectionConfiguration.ClearTrainingData()
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ClearTrainingData

## -description

Deletes all voice training data from the [ActivationSignalDetector](activationsignaldetector.md) for the digital assistant.

> [!Important]
> To avoid possible concurrency issues, we recommend using [ClearTrainingDataAsync](activationsignaldetectionconfiguration_cleartrainingdataasync_245705916.md) instead.

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data. For example, training a spoken keyword detector to only detect the keyword when spoken by a specific person.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.  

## -see-also

[ClearTrainingDataAsync](activationsignaldetectionconfiguration_cleartrainingdataasync_245705916.md)

## -examples
