---
-api-id: T:Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ISpeechRecognitionConstraint : 
-->

# Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint

## -description
Represents a constraint for a [SpeechRecognizer](speechrecognizer.md) object.

## -remarks
Constraints, or grammars, define the spoken words and phrases that can be matched by the speech recognizer.

You can specify one of the pre-defined, web-service grammars (see [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md)) or you can create your own custom grammar (see [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md), [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md), and [SpeechRecognitionVoiceCommandDefinitionConstraint](speechrecognitionvoicecommanddefinitionconstraint.md)) that is installed with your app.

To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -> Privacy -> Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](/windows/uwp/input-and-devices/speech-recognition).

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md), [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md), [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md), [SpeechRecognizer.Constraints](speechrecognizer_constraints.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
