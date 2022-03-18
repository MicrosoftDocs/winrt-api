---
-api-id: P:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.TrainingDataFormat
-api-type: winrt property
---

<!-- Property syntax.
public ActivationSignalDetectionTrainingDataFormat TrainingDataFormat { get; }
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.TrainingDataFormat

## -description

Gets the supported data format used for signal detection training with this configuration (if available).

## -property-value

The signal detection data format.

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data. For example, training a spoken keyword detector to only detect the keyword when spoken by a specific person.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.  

## -see-also

[ActivationSignalDetector](activationsignaldetector.md), [ApplyTrainingData](activationsignaldetectionconfiguration_applytrainingdata_740648587.md), [ApplyTrainingDataAsync](activationsignaldetectionconfiguration_applytrainingdataasync_907910427.md)

## -examples
