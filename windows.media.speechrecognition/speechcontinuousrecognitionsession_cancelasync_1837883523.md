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
A [ResultGenerated](speechcontinuousrecognitionsession_resultgenerated.md) event can occur after a call to CancelAsync if it exists on the stack when the call is made.

[StopAsync](speechcontinuousrecognitionsession_stopasync_1648475005.md) passes pending results to the [ResultGenerated](speechcontinuousrecognitionsession_resultgenerated.md) event.

## -examples

## -see-also
[StartAsync](speechcontinuousrecognitionsession_startasync_192219967.md), [PauseAsync](speechcontinuousrecognitionsession_pauseasync_576113822.md), [StopAsync](speechcontinuousrecognitionsession_stopasync_1648475005.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
