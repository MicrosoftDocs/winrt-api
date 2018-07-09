---
-api-id: T:Windows.Media.SpeechRecognition.SpeechContinuousRecognitionMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.SpeechRecognition.SpeechContinuousRecognitionMode : int
-->

# SpeechContinuousRecognitionMode

## -description
Specifies the behavior of the speech recognizer during a continuous recognition session.

## -enum-fields
### -field Default:0
Speech recognizer continues listening for and processing speech input after a recognition result is generated.

### -field PauseOnRecognition:1
Speech recognizer pauses and suspends further processing of speech input when a recognition result is generated.


## -remarks
To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -> Privacy -> Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](http://msdn.microsoft.com/library/553c0fb7-35bc-4894-9ef1-906139e17552).

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)