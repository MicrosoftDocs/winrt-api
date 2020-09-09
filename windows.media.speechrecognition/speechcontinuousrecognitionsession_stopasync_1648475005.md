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
[StartAsync](speechcontinuousrecognitionsession_startasync_192219967.md), [PauseAsync](speechcontinuousrecognitionsession_pauseasync_576113822.md), [CancelAsync](speechcontinuousrecognitionsession_cancelasync_1837883523.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
