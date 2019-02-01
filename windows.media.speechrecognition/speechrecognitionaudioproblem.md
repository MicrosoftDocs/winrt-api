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
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [RecognitionQualityDegrading](speechrecognizer_recognitionqualitydegrading.md), [SpeechRecognitionQualityDegradingEventArgs](speechrecognitionqualitydegradingeventargs.md), [Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
