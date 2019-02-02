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

[Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
