---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionCompilationResult
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechRecognitionCompilationResult : Windows.Media.SpeechRecognition.ISpeechRecognitionCompilationResult
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionCompilationResult

## -description
The result of compiling the constraints set for a [SpeechRecognizer](speechrecognizer.md) object.

## -remarks
Call [SpeechRecognizer.CompileConstraintsAsync](speechrecognizer_compileconstraintsasync.md) to obtain an instance of this class.

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync.md) must always be called before [RecognizeAsync](speechrecognizer_recognizeasync.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [ISpeechRecognitionConstraint](ispeechrecognitionconstraint.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)