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
[Set speech recognition timeouts](https://msdn.microsoft.com/library/58f446ac-4a56-454d-8125-62a2c4dbfcc8), [Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
