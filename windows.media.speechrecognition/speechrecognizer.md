---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognizer
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechRecognizer : Windows.Foundation.IClosable, Windows.Media.SpeechRecognition.ISpeechRecognizer, Windows.Media.SpeechRecognition.ISpeechRecognizer2
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer

## -description

Enables speech recognition with either a default or a custom graphical user interface (GUI).

## -remarks

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync_1901700993.md) must always be called before [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | TrySetSystemSpeechLanguageAsync |

## -examples

## -see-also

[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis), [Holographic voice input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicVoiceInput)
