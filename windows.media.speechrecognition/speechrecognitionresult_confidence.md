---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognitionResult.Confidence
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.SpeechRecognition.SpeechRecognitionConfidence Confidence { get; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionResult.Confidence

## -description
Gets a value that indicates the confidence of the speech recognizer in the recognition result.

## -property-value
The confidence level of the recognition result.

## -remarks
Call [GetAlternates](speechrecognitionresult_getalternates_1293755280.md) for the full collection of recognition alternatives, ordered by confidence from most likely to least likely. The first item in the collection is the recognition result indicated by the parent object.



## -examples

## -see-also
[RawConfidence](speechrecognitionresult_rawconfidence.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
