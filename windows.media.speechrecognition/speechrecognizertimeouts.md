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
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Set speech recognition timeouts](/windows/uwp/input-and-devices/set-speech-recognition-timeouts), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
