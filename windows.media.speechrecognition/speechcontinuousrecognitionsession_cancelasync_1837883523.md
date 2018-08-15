---
-api-id: M:Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.CancelAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction CancelAsync()
-->

# Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.CancelAsync

## -description
Asynchronously cancel the continuous speech recognition session and discard all pending recognition results.

## -returns
An asynchronous handler called when the operation is complete.

## -remarks
A [ResultGenerated](speechcontinuousrecognitionsession_resultgenerated.md) event can occur after a call to [CancelAsync](speechcontinuousrecognitionsession_cancelasync_1837883523.md) if it exists on the stack when the call is made.

[StopAsync](speechcontinuousrecognitionsession_stopasync_1648475005.md) passes pending results to the [ResultGenerated](speechcontinuousrecognitionsession_resultgenerated.md) event.

## -examples

## -see-also
[StartAsync](speechcontinuousrecognitionsession_startasync_192219967.md), [PauseAsync](speechcontinuousrecognitionsession_pauseasync_576113822.md), [StopAsync](speechcontinuousrecognitionsession_stopasync_1648475005.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)