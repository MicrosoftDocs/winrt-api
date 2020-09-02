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

Call [SpeechRecognizer.CompileConstraintsAsync](speechrecognizer_compileconstraintsasync_1901700993.md) to obtain an instance of this class.

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync_1901700993.md) must always be called before [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

## -examples

## -see-also

[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [ISpeechRecognitionConstraint](ispeechrecognitionconstraint.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis), [Holographic voice input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicVoiceInput)
