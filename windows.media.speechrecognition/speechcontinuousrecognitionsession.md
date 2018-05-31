---
-api-id: T:Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechContinuousRecognitionSession : Windows.Media.SpeechRecognition.ISpeechContinuousRecognitionSession
-->

# Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession

## -description

Manages speech input for free-form dictation, or an arbitrary sequence of words or phrases that are defined in a local grammar file constraint.

## -remarks

An app retrieves this object through the [SpeechRecognizer.ContinuousRecognitionSession](speechrecognizer_continuousrecognitionsession.md) property.

To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -> Privacy -> Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](http://msdn.microsoft.com/library/553c0fb7-35bc-4894-9ef1-906139e17552).

## -examples

## -see-also

[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897), [Holographic voice input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicVoiceInput)