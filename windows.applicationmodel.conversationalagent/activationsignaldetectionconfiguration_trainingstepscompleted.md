---
-api-id: P:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.TrainingStepsCompleted
-api-type: winrt property
---

<!-- Property syntax.
public uint TrainingStepsCompleted { get; }
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.TrainingStepsCompleted

## -description

Gets the number of steps completed in the training process of this configuration (if available).

## -property-value

THe number of training steps completed.

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data. For example, training a spoken keyword detector to only detect the keyword when spoken by a specific person.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.  

## -see-also

[TrainingStepsRemaining](activationsignaldetectionconfiguration_trainingstepsremaining.md), [TrainingStepCompletionMaxAllowedTime](activationsignaldetectionconfiguration_trainingstepcompletionmaxallowedtime.md), [ActivationSignalDetector](activationsignaldetector.md), [ApplyTrainingData](activationsignaldetectionconfiguration_applytrainingdata_740648587.md), [ApplyTrainingDataAsync](activationsignaldetectionconfiguration_applytrainingdataasync_907910427.md)

## -examples
