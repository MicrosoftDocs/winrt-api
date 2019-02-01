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

To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -> Privacy -> Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](https://msdn.microsoft.com/library/553c0fb7-35bc-4894-9ef1-906139e17552).

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
