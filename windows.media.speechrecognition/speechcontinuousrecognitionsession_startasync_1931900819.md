---
-api-id: M:Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.StartAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StartAsync()
-->

# Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.StartAsync

## -description
*Overload*

Asynchronously begin a continuous speech recognition session with a [SpeechContinuousRecognitionMode](speechcontinuousrecognitionmode.md) of [Default](speechcontinuousrecognitionmode.md).

## -returns
An asynchronous handler called when the operation is complete.

## -remarks
[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync.md) must always be called before [StartAsync](speechcontinuousrecognitionsession_startasync_1931900819.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

## -examples

## -see-also
[StartAsync](speechcontinuousrecognitionsession_startasync.md), [PauseAsync](speechcontinuousrecognitionsession_pauseasync.md), [StopAsync](speechcontinuousrecognitionsession_stopasync.md), [CancelAsync](speechcontinuousrecognitionsession_cancelasync.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)