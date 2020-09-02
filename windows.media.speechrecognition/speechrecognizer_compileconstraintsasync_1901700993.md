---
-api-id: M:Windows.Media.SpeechRecognition.SpeechRecognizer.CompileConstraintsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.SpeechRecognition.SpeechRecognitionCompilationResult> CompileConstraintsAsync()
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.CompileConstraintsAsync

## -description
Asynchronously compile all constraints specified by the [Constraints](speechrecognizer_constraints.md) property.

## -returns
The result of the constraints compilation as a [SpeechRecognitionCompilationResult](speechrecognitioncompilationresult.md) object.

## -remarks
CompileConstraintsAsync must always be called before [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

This method returns an error if:

+ [SpeechRecognizerState](speechrecognizerstate.md) is not [Idle](speechrecognizerstate.md) or [Paused](speechrecognizerstate.md).
+ One or more constraints are specified when the recognition session is initialized, recognition is [Paused](speechrecognizerstate.md), all constraints are removed, and recognition is resumed.
+ No constraints are specified when the recognition session is initialized, recognition is [Paused](speechrecognizerstate.md), constraints are added, and recognition is resumed.

To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -> Privacy -> Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](/windows/uwp/input-and-devices/speech-recognition).

## -examples

## -see-also
[Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
