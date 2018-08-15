---
-api-id: M:Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.StopAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StopAsync()
-->

# Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.StopAsync

## -description
Asynchronously end a continuous speech recognition session and pass all pending recognition results to the [ResultGenerated](speechcontinuousrecognitionsession_resultgenerated.md) event.

## -returns
An asynchronous handler called when the operation is complete.

## -remarks
[CancelAsync](speechcontinuousrecognitionsession_cancelasync_1837883523.md) discards all pending results.

## -examples

## -see-also
[StartAsync](speechcontinuousrecognitionsession_startasync_192219967.md), [PauseAsync](speechcontinuousrecognitionsession_pauseasync_576113822.md), [CancelAsync](speechcontinuousrecognitionsession_cancelasync_1837883523.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)