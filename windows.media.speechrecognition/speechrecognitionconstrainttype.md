---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionConstraintType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.SpeechRecognition.SpeechRecognitionConstraintType : int
-->

# SpeechRecognitionConstraintType

## -description
Specifies the grammar definition constraint used for speech recognition.

## -enum-fields
### -field Topic:0
A pre-defined, web-service grammar constraint based on a dictation topic. See [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md).

### -field List:1
A constraint based on a list of words or phrases. See [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md).

### -field Grammar:2
A constraint based on a Speech Recognition Grammar Specification (SRGS) grammar file. See [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md).

### -field VoiceCommandDefinition:3
A constraint based on a Voice Command Definition (VCD) file. See [SpeechRecognitionVoiceCommandDefinitionConstraint](speechrecognitionvoicecommanddefinitionconstraint.md).


## -remarks
Constraints, or grammars, define the spoken words and phrases that can be matched by the speech recognizer.

You can specify one of the pre-defined, web-service grammars (see [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md)) or you can create your own custom grammar (see [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md), [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md), and [SpeechRecognitionVoiceCommandDefinitionConstraint](speechrecognitionvoicecommanddefinitionconstraint.md)) that is installed with your app.

To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -> Privacy -> Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](/windows/uwp/input-and-devices/speech-recognition).

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
