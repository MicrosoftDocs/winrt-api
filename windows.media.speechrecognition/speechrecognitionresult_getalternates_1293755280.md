---
-api-id: M:Windows.Media.SpeechRecognition.SpeechRecognitionResult.GetAlternates(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.SpeechRecognition.SpeechRecognitionResult> GetAlternates(System.UInt32 maxAlternates)
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionResult.GetAlternates

## -description
Gets a collection of recognition result alternatives, ordered by [RawConfidence](speechrecognitionresult_rawconfidence.md) from most likely to least likely. The first item in the collection is the recognition result indicated by the parent object.

## -parameters
### -param maxAlternates
The maximum number of speech recognition results to return in the collection.

## -returns
A collection of speech recognition results, ordered by confidence from most likely to least likely.

## -remarks

## -examples

## -see-also
[Confidence](speechrecognitionresult_confidence.md), [RawConfidence](speechrecognitionresult_rawconfidence.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
