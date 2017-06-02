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

If a [SpeechContinuousRecognitionSession](speechcontinuousrecognitionsession.md) is underway, [Close](speechrecognizer_close.md) is functionally equivalent to calling [CancelAsync](speechcontinuousrecognitionsession_cancelasync.md).

## -exceptions
### System.ObjectDisposedException

Thrown if either [RecognizeAsync](speechrecognizer_recognizeasync.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync.md) is in progress.

## -remarks

## -examples

## -see-also
[Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)