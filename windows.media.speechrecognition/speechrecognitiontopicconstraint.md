---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionTopicConstraint
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechRecognitionTopicConstraint : Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint, Windows.Media.SpeechRecognition.ISpeechRecognitionTopicConstraint
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionTopicConstraint

## -description
A pre-defined grammar constraint (specifed by [SpeechRecognitionScenario](speechrecognitionscenario.md)) provided through a web service.

## -remarks
Constraints, or grammars, define the spoken words and phrases that can be matched by the speech recognizer.

You can specify one of the pre-defined, web-service grammars or you can create your own custom grammar (see [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md), [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md), and [SpeechRecognitionVoiceCommandDefinitionConstraint](speechrecognitionvoicecommanddefinitionconstraint.md)) that is installed with your app.

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync_1901700993.md) must always be called before [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in **Settings -> Privacy -> Speech, inking, and typing**. For more detail on recognition constraints, see "Recognize speech input" in [Speech recognition](/windows/uwp/input-and-devices/speech-recognition).

> [!NOTE]
> Increase recognition accuracy during a lengthy dictation session by using a [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md) in conjunction with the SpeechRecognitionTopicConstraint. This lets you provide a set of domain-specific keywords that you think are likely to be used during dictation.  

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [SpeechRecognitionConstraintType](speechrecognitionconstrainttype.md), [ISpeechRecognitionConstraint](ispeechrecognitionconstraint.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
