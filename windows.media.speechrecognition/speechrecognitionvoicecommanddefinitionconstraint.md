---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionVoiceCommandDefinitionConstraint
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechRecognitionVoiceCommandDefinitionConstraint : Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint, Windows.Media.SpeechRecognition.ISpeechRecognitionVoiceCommandDefinitionConstraint
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionVoiceCommandDefinitionConstraint

## -description
A constraint for a [SpeechRecognizer](speechrecognizer.md) object based on a [Voice Command Definition](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2) file.

## -remarks
Access the [SpeechRecognitionResult.Constraint](speechrecognitionresult_constraint.md) property to obtain an instance of this class.

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync_1901700993.md) must always be called before [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [SpeechRecognitionConstraintType](speechrecognitionconstrainttype.md), [ISpeechRecognitionConstraint](ispeechrecognitionconstraint.md), [ elements and attributes](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
