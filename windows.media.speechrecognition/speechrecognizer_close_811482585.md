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
### System.ObjectDisposedException

Thrown if either [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md) is in progress.

## -remarks
If a [SpeechContinuousRecognitionSession](speechcontinuousrecognitionsession.md) is underway, [Close](speechrecognizer_close_811482585.md) is functionally equivalent to calling [CancelAsync](speechcontinuousrecognitionsession_cancelasync_1837883523.md).


## -examples

## -see-also
[Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
