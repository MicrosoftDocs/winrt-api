---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognizerState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.SpeechRecognition.SpeechRecognizerState : int
-->

# SpeechRecognizerState

## -description
Specifies the state of the speech recognizer.

## -enum-fields
### -field Idle:0
Indicates that speech recognition is not active and the speech recognizer is not capturing (listening for) audio input.

In this state, [SpeechRecognizer.RecognizeAsync](speechrecognizer_recognizeasync.md), [SpeechRecognizer.RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync.md), [SpeechContinuousRecognitionSession.StartAsync](speechcontinuousrecognitionsession_startasync.md), or [SpeechRecognizer.CompileConstraintsAsync](speechrecognizer_compileconstraintsasync.md) can be called.

### -field Capturing:1
Indicates that the speech recognizer is capturing (listening for) audio input from the user.

Useful for providing dynamic feedback during standard or continuous recognition.

### -field Processing:2
Indicates that the speech recognizer is processing (attempting to recognize) audio input from the user. The recognizer is no longer capturing (listening for) audio input from the user.

During standard recognition, the state can occur after the recognizer has stopped capturing audio input and before a recognition result is returned.

During continuous recognition, this state can occur after [StopAsync](speechcontinuousrecognitionsession_stopasync.md) has been called and before the [Completed](speechcontinuousrecognitionsession_completed.md) event fires.

Useful for indicating that a user should stop speaking.

### -field SoundStarted:3
Indicates that the speech recognizer has detected sound on the audio stream.

Useful for indicating that sound (not necessarily speech) has been detected.

### -field SoundEnded:4
Indicates that the speech recognizer no longer detects sound on the audio stream.

Useful for hiding speech recognition UI. However, the recognition session is still active.

### -field SpeechDetected:5
Indicates that the speech recognizer has detected speech input on the audio stream.

Useful for indicating that speech has been detected.

### -field Paused:6
Only valid for continuous recognition.

Indicates that the speech recognition session is still active, but the speech recognizer is no longer processing (attempting to recognize) audio input. Ongoing audio input is buffered.

In this state, [constraints](speechrecognizer_constraints.md) can be added, removed, and [compiled](speechrecognizer_compileconstraintsasync.md).

If one or more constraints are specified when the recognition session is initialized, removing all constraints and resuming recognition will result in an error.

Similarly, if no constraints are specified when the recognition session is initialized, adding constraints and resuming recognition will also result in an error.


## -remarks

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [PauseAsync](speechcontinuousrecognitionsession_pauseasync.md), [Resume](speechcontinuousrecognitionsession_resume.md), [SpeechRecognizerStateChangedEventArgs.State](speechrecognizerstatechangedeventargs_state.md), [SpeechRecognizer.State](speechrecognizer_state.md), [SpeechRecognizer.StateChanged](speechrecognizer_statechanged.md), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)