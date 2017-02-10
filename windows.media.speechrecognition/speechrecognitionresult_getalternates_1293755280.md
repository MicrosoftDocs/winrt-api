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
[Confidence](speechrecognitionresult_confidence.md), [RawConfidence](speechrecognitionresult_rawconfidence.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)