---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognizerTimeouts.BabbleTimeout
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan BabbleTimeout { get;  set; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognizerTimeouts.BabbleTimeout

## -description
Gets and sets the length of time that a [SpeechRecognizer](speechrecognizer.md) continues to listen while receiving unrecognizable sounds (babble) before it assumes speech input has ended and finalizes the recognition operation.

## -property-value
The length of time that the speech recognizer continues to listen while detecting only non-speech input such as background noise. The default is 0 seconds (not activated).

## -remarks

## -examples

## -see-also
[Set speech recognition timeouts](/windows/uwp/input-and-devices/set-speech-recognition-timeouts), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
