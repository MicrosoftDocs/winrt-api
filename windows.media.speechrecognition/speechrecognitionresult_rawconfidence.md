---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognitionResult.RawConfidence
-api-type: winrt property
---

<!-- Property syntax
public double RawConfidence { get; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionResult.RawConfidence

## -description
Gets a value that indicates the relative confidence of the [SpeechRecognitionResult](speechrecognitionresult.md) when compared with a collection of alternatives returned with the recognition result.

## -property-value
The confidence level of the result.

## -remarks
[RawConfidence](speechrecognitionresult_rawconfidence.md) does not indicate the likelihood that a phrase was correctly recognized. Instead it provides a way to compare the relative accuracy of alternatives returned with the recognition result. For example, a [RawConfidence](speechrecognitionresult_rawconfidence.md) score of 0.8 does not mean that a result is 80% likely to be correct; it means the phrase is more likely than an alternative with a [RawConfidence](speechrecognitionresult_rawconfidence.md) of 0.7.

Do not use [RawConfidence](speechrecognitionresult_rawconfidence.md) to determine whether a result should be discarded. [RawConfidence](speechrecognitionresult_rawconfidence.md) values are unique to each recognition engine and can vary between sessions or devices. Instead, check the [Confidence](speechrecognitionresult_confidence.md) property, which indicates a [SpeechRecognitionConfidence](speechrecognitionconfidence.md) of High, Medium, Low or Rejected.



## -examples

## -see-also
[Confidence](speechrecognitionresult_confidence.md), [SpeechRecognitionConfidence](speechrecognitionconfidence.md), [Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
