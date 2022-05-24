---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.DetectionConfigurationTrainingStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum DetectionConfigurationTrainingStatus : int 
-->

# Windows.ApplicationModel.ConversationalAgent.DetectionConfigurationTrainingStatus

## -description

Specifies the voice training data states recognized by the [ActivationSignalDetector](activationsignaldetector.md) for the digital assistant.

> [!NOTE]
> These determinations are made by the training algorithms of an individual signal detector and may be specific to the hardware or software implementations of the detector.

## -enum-fields

### -field Success:0

Signal detection training was successful.

### -field FormatNotSupported:1

Training data format is not recognized by the signal detector.

### -field VoiceTooQuiet:2

Training data cannot be processed by the signal detector due to user speaking too quietly.

### -field VoiceTooLoud:3

Training data cannot be processed by the signal detector due to user speaking too loudly.

### -field VoiceTooFast:4

Training data cannot be processed by the signal detector due to user speaking too fast.

### -field VoiceTooSlow:5

Training data cannot be processed by the signal detector due to user speaking too slowly.

### -field VoiceQualityProblem:6

Training data cannot be processed by the signal detector due to poor quality of speech input.

### -field TrainingSystemInternalError:7

An internal error, unrelated to the input data format, was encountered during signal detection training.

### -field TrainingTimedOut: 8

Training process took too long and has timed out. Any training data provided during this training cycle is discarded.

### -field ConfigurationNotFound: 9

The request failed because a configuration with the specified parameters was not found.

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data. For example, training a spoken keyword detector to only detect the keyword when spoken by a specific person.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.

## -see-also

[ActivationSignalDetectionConfiguration.ApplyTrainingData](activationsignaldetectionconfiguration_applytrainingdata_740648587.md), [ActivationSignalDetectionConfiguration.ApplyTrainingDataAsync](activationsignaldetectionconfiguration_applytrainingdataasync_907910427.md)

## -examples
