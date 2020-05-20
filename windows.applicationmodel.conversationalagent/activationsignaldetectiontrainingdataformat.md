---
-api-id: T:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionTrainingDataFormat
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ActivationSignalDetectionTrainingDataFormat : int 
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionTrainingDataFormat

## -description

Specifies the activation signal training data formats supported by the [ActivationSignalDetector](activationsignaldetector.md) for the digital assistant.

## -enum-fields

### -field Voice8kHz8BitMono:0

Training data is voice audio in 8-bit 8kHz mono.

### -field Voice8kHz16BitMono:1

Training data is voice audio in 16-bit 8kHz mono.

### -field Voice16kHz8BitMono:2

Training data is voice audio in 8-bit 16kHz mono.

### -field Voice16kHz16BitMono:3

Training data is voice audio in 16-bit 16kHz mono.

### -field VoiceOEMDefined:4

Training data is voice audio is defined by an OEM.

### -field Audio44kHz8BitMono:5

Training data is generic audio in 8-bit 44kHz mono.

### -field Audio44kHz16BitMono:6

Training data is generic audio in 16-bit 44kHz mono.

### -field Audio48kHz8BitMono:7

Training data is generic audio in 8-bit 48kHz mono.

### -field Audio48kHz16BitMono:8

Training data is generic audio in 16-bit 48kHz mono.

### -field AudioOEMDefined:9

Training data is generic audio in a format specified by a hardware provider.

### -field OtherOEMDefined:10

Training data is in a format specified by a hardware provider.

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by applying algorithmic customizations to the detector based on speech data (the detector provides these customizations). For example, training a spoken keyword detector to only detect the keyword when spoken by a specific person.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.

## -see-also

[ActivationSignalDetectionConfiguration.ApplyTrainingData](activationsignaldetectionconfiguration_applytrainingdata_740648587.md), [ActivationSignalDetectionConfiguration.ApplyTrainingDataAsync](activationsignaldetectionconfiguration_applytrainingdataasync_907910427.md)

## -examples
