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

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync.md) must always be called before [RecognizeAsync](speechrecognizer_recognizeasync.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

## -returns
The result of the constraints compilation as a [SpeechRecognitionCompilationResult](speechrecognitioncompilationresult.md) object.

## -remarks

This method returns an error if:

+ [SpeechRecognizerState](speechrecognizerstate.md) is not [Idle](speechrecognizerstate.md) or [Paused](speechrecognizerstate.md).
+ One or more constraints are specified when the recognition session is initialized, recognition is [Paused](speechrecognizerstate.md), all constraints are removed, and recognition is resumed.
+ No constraints are specified when the recognition session is initialized, recognition is [Paused](speechrecognizerstate.md), constraints are added, and recognition is resumed.


## -examples

## -see-also
[Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)