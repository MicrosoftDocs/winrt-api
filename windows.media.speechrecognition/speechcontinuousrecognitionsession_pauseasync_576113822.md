---
-api-id: M:Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.PauseAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction PauseAsync()
-->

# Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.PauseAsync

## -description
Asynchronously pause a continuous speech recognition session to update a local [grammar file](speechrecognitiongrammarfileconstraint.md) or [list constraint](speechrecognitionlistconstraint.md).

## -returns
An asynchronous handler called when the operation is complete.

## -remarks
An error is returned if [SpeechRecognizerState](speechrecognizerstate.md) is [Idle](speechrecognizerstate.md) or [Paused](speechrecognizerstate.md).

If the list of constraints is empty (which defaults to a [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md)), or a [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md) is present in the list of constraints, PauseAsync fails with error code COR_E_INVALIDOPERATION.

## -examples

## -see-also
[StartAsync](speechcontinuousrecognitionsession_startasync_192219967.md), [StopAsync](speechcontinuousrecognitionsession_stopasync_1648475005.md), [CancelAsync](speechcontinuousrecognitionsession_cancelasync_1837883523.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
