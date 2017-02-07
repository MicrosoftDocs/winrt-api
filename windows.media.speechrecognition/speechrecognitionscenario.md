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

> [!NOTE]
> To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -&gt; Privacy -&gt; Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](http://msdn.microsoft.com/library/553c0fb7-35bc-4894-9ef1-906139e17552).

## -enum-fields
### -field WebSearch:0
A web search scenario.

### -field Dictation:1
A dictation scenario.

### -field FormFilling:2
A form input scenario.


## -remarks

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)