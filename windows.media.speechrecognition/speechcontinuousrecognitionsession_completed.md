---
-api-id: E:Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.Completed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Completed<Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession,  Windows.Media.SpeechRecognition.SpeechContinuousRecognitionCompletedEventArgs>
-->

# Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.Completed

## -description
Occurs when a continuous recognition session ends.

## -remarks
When an application suspends and resumes during a speech recognition session, it is important to check the [SpeechContinuousRecognitionCompletedEventArgs](speechcontinuousrecognitioncompletedeventargs.md) Status property for Success.  The API may give a UserCanceled result indicating that speech recognition needs to be restarted.

## -examples

## -see-also
[SpeechContinuousRecognitionCompletedEventArgs](speechcontinuousrecognitioncompletedeventargs.md), [ResultGenerated](speechcontinuousrecognitionsession_resultgenerated.md), [Speech interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/speech-interactions), [Speech design guidelines](https://docs.microsoft.com/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
