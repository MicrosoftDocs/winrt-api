---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognizerTimeouts
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechRecognizerTimeouts : Windows.Media.SpeechRecognition.ISpeechRecognizerTimeouts
-->

# Windows.Media.SpeechRecognition.SpeechRecognizerTimeouts

## -description
The timespan that a speech recognizer ignores silence or unrecognizable sounds (babble) and continues listening for speech input.

## -remarks
An app retrieves this object through the [SpeechRecognizer.Timeouts](speechrecognizer_timeouts.md) property.

The recognizer finalizes each operation when the specified time span elapses.

[InitialSilenceTimeout](speechrecognizertimeouts_initialsilencetimeout.md) and [EndSilenceTimeout](speechrecognizertimeouts_endsilencetimeout.md) both relate to silence, but have different uses. While [EndSilenceTimeout](speechrecognizertimeouts_endsilencetimeout.md) applies if speech input has already occurred, [InitialSilenceTimeout](speechrecognizertimeouts_initialsilencetimeout.md) applies if no speech input is received at all.

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Set speech recognition timeouts](http://msdn.microsoft.com/library/58f446ac-4a56-454d-8125-62a2c4dbfcc8), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)