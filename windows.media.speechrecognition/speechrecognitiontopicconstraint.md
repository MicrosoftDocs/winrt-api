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

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync.md) must always be called before [RecognizeAsync](speechrecognizer_recognizeasync.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in **Settings -&gt; Privacy -&gt; Speech, inking, and typing**. For more detail on recognition constraints, see "Recognize speech input" in [Speech recognition](http://msdn.microsoft.com/library/553c0fb7-35bc-4894-9ef1-906139e17552).

> [!NOTE]
> Increase dictation accuracy by using a [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md) in conjunction with the SpeechRecognitionTopicConstraint. This lets you provide a set of domain-specific keywords that you think are likely to be used during dictation.  

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [SpeechRecognitionConstraintType](speechrecognitionconstrainttype.md), [ISpeechRecognitionConstraint](ispeechrecognitionconstraint.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)