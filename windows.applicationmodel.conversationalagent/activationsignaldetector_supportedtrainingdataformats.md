---
-api-id: P:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.SupportedTrainingDataFormats
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<ActivationSignalDetectionTrainingDataFormat> SupportedTrainingDataFormats { get; }
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.SupportedTrainingDataFormats

## -description

Gets the supported formats for training an [ActivationSignalDetector](activationsignaldetector.md).

## -property-value

An [ActivationSignalDetectionConfiguration.TrainingDataFormat](activationsignaldetectionconfiguration_trainingdataformat.md) collection for training an [ActivationSignalDetector](activationsignaldetector.md).

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data. For example, training a spoken keyword detector to only detect the keyword when spoken by a specific person.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.  

## -see-also

## -examples
