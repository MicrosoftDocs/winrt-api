---
-api-id: M:Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.Resume
-api-type: winrt method
---

<!-- Method syntax
public void Resume()
-->

# Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession.Resume

## -description
Resumes a continuous speech recognition session, if paused.

## -remarks
An error is returned if [SpeechRecognizerState](speechrecognizerstate.md) is not [Paused](speechrecognizerstate.md).

If a [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md) is added after [PauseAsync](speechcontinuousrecognitionsession_pauseasync_576113822.md), Resume fails with error code COR_E_INVALIDOPERATION.

## -examples

## -see-also
[Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
