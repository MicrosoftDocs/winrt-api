---
-api-id: M:Windows.Media.SpeechRecognition.SpeechRecognizer.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.Close

## -description
Disposes the speech recognizer by freeing, releasing, or resetting allocated resources.

## -exceptions
### T:System.ObjectDisposedException

Thrown if either [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md) is in progress.

## -remarks
If a [SpeechContinuousRecognitionSession](speechcontinuousrecognitionsession.md) is underway, Close is functionally equivalent to calling [CancelAsync](speechcontinuousrecognitionsession_cancelasync_1837883523.md).


## -examples

## -see-also
[Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
