---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionScenario
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.SpeechRecognition.SpeechRecognitionScenario : int
-->

# SpeechRecognitionScenario

## -description
Specifies the scenario used to optimize speech recognition for a web-service constraint (created through a [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md) object).

## -enum-fields
### -field WebSearch:0
A grammar constraint optimized for web search recognition scenarios.

### -field Dictation:1
A gramar constraint optimized for continuous dictation recognition scenarios.

### -field FormFilling:2
A grammar constraint optimized for form input recognition scenarios.

## -remarks
To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -> Privacy -> Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](http://msdn.microsoft.com/library/553c0fb7-35bc-4894-9ef1-906139e17552).

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)