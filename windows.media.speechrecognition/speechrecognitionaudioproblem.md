---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionAudioProblem
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.SpeechRecognition.SpeechRecognitionAudioProblem : int
-->

# SpeechRecognitionAudioProblem

## -description
Specifies the type of audio problem detected.

## -enum-fields
### -field None:0
No audio problem.

### -field TooNoisy:1
Too much background noise interfering with the speech recognition.

### -field NoSignal:2
No audio. For example, the microphone may have been muted.

### -field TooLoud:3
Input volume too high.

### -field TooQuiet:4
Input volume too quiet.

### -field TooFast:5
User spoke too fast.

### -field TooSlow:6
User spoke too slowly.


## -remarks

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [RecognitionQualityDegrading](speechrecognizer_recognitionqualitydegrading.md), [SpeechRecognitionQualityDegradingEventArgs](speechrecognitionqualitydegradingeventargs.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
