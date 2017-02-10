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
Call [GetAlternates](speechrecognitionresult_getalternates.md) for the full collection of recognition alternatives, ordered by confidence from most likely to least likely. The first item in the collection is the recognition result indicated by the parent object.



## -examples

## -see-also
[RawConfidence](speechrecognitionresult_rawconfidence.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)