---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognitionResult.Constraint
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint Constraint { get; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionResult.Constraint

## -description

Gets the constraint used for the recognition result.

## -property-value

The constraint used for the recognition result. Null for remote recognition using predefined grammars ([SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md)).

## -remarks

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync_1901700993.md) must be called before [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

## -examples

## -see-also

[Speech interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/speech-interactions), [Speech design guidelines](https://docs.microsoft.com/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
