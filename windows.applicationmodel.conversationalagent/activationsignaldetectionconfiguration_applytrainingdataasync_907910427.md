---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ApplyTrainingDataAsync(Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionTrainingDataFormat,Windows.Storage.Streams.IInputStream)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<DetectionConfigurationTrainingStatus> ActivationSignalDetectionConfiguration.ApplyTrainingDataAsync(ActivationSignalDetectionTrainingDataFormat trainingDataFormat, IInputStream trainingData)
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ApplyTrainingDataAsync

## -description

Asynchronously provides input data in the specified format and attempts to complete a training step (if a training process is available for the signal detector of this configuration).

## -parameters

### -param trainingDataFormat

The voice training data formats supported by the [ActivationSignalDetector](activationsignaldetector.md) for the digital assistant.

### -param trainingData

The voice training data.

## -returns

The voice training data states recognized by the [ActivationSignalDetector](activationsignaldetector.md) for the digital assistant.

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data. For example, training a spoken keyword detector to only detect the keyword when spoken by a specific person.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.  

## -see-also

[ActivationSignalDetector](activationsignaldetector.md)

## -examples
