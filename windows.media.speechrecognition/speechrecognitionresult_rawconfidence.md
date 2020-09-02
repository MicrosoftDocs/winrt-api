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
RawConfidence does not indicate the likelihood that a phrase was correctly recognized. Instead it provides a way to compare the relative accuracy of alternatives returned with the recognition result. For example, a RawConfidence score of 0.8 does not mean that a result is 80% likely to be correct; it means the phrase is more likely than an alternative with a RawConfidence of 0.7.

Do not use RawConfidence to determine whether a result should be discarded. RawConfidence values are unique to each recognition engine and can vary between sessions or devices. Instead, check the [Confidence](speechrecognitionresult_confidence.md) property, which indicates a [SpeechRecognitionConfidence](speechrecognitionconfidence.md) of High, Medium, Low or Rejected.



## -examples

## -see-also
[Confidence](speechrecognitionresult_confidence.md), [SpeechRecognitionConfidence](speechrecognitionconfidence.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
