---
-api-id: P:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.TrainingStepCompletionMaxAllowedTime
-api-type: winrt property
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.TrainingStepCompletionMaxAllowedTime

<!--
public uint TrainingStepCompletionMaxAllowedTime { get; }
-->

## -description

Gets the maximum time allowed to complete a training step for this configuration (if available).

## -property-value

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data. For example, training a spoken keyword detector to only detect the keyword when spoken by a specific person.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.  

## -see-also

[TrainingStepsRemaining](activationsignaldetectionconfiguration_trainingstepsremaining.md), [TrainingStepsCompleted](activationsignaldetectionconfiguration_trainingstepscompleted.md), [ActivationSignalDetector](activationsignaldetector.md), [ApplyTrainingData](activationsignaldetectionconfiguration_applytrainingdata_740648587.md), [ApplyTrainingDataAsync](activationsignaldetectionconfiguration_applytrainingdataasync_907910427.md)

## -examples
