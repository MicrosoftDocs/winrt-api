---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionVoiceCommandDefinitionConstraint
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechRecognitionVoiceCommandDefinitionConstraint : Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint, Windows.Media.SpeechRecognition.ISpeechRecognitionVoiceCommandDefinitionConstraint
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionVoiceCommandDefinitionConstraint

## -description
A constraint for a [SpeechRecognizer](speechrecognizer.md) object based on a [](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md) file.

## -remarks
Access the [SpeechRecognitionResult.Constraint](speechrecognitionresult_constraint.md) property to obtain an instance of this class.

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync_1901700993.md) must always be called before [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [SpeechRecognitionConstraintType](speechrecognitionconstrainttype.md), [ISpeechRecognitionConstraint](ispeechrecognitionconstraint.md), [ elements and attributes](https://docs.microsoft.com/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2.md), [Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
