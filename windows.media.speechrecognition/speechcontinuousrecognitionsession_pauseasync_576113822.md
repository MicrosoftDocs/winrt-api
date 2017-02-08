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

If a [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md) is present in the list of constraints than [PauseAsync](speechcontinuousrecognitionsession_pauseasync.md) fails with error code COR_E_INVALIDOPERATION.

## -examples

## -see-also
[StartAsync](speechcontinuousrecognitionsession_startasync.md), [StopAsync](speechcontinuousrecognitionsession_stopasync.md), [CancelAsync](speechcontinuousrecognitionsession_cancelasync.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)