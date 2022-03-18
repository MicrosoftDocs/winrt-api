---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionResultStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.SpeechRecognition.SpeechRecognitionResultStatus : int
-->

# SpeechRecognitionResultStatus

## -description
Specifies the possible result states of a speech recognition session or from the compiling of grammar constraints.

## -enum-fields
### -field Success:0
The recognition session or compilation succeeded.

### -field TopicLanguageNotSupported:1
A topic constraint was set for an unsupported language.

### -field GrammarLanguageMismatch:2
The language of the speech recognizer does not match the language of a grammar.

### -field GrammarCompilationFailure:3
A grammar failed to compile.

### -field AudioQualityFailure:4
Audio problems caused recognition to fail.

### -field UserCanceled:5
User canceled recognition session.

### -field Unknown:6
An unknown problem caused recognition or compilation to fail.

### -field TimeoutExceeded:7
A timeout due to extended silence or poor audio caused recognition to fail.

> Not supported in Windows 8 apps and Windows Phone apps.

### -field PauseLimitExceeded:8
An extended pause, or excessive processing time, caused recognition to fail.



> Not supported in Windows 8 apps and Windows Phone apps.

### -field NetworkFailure:9
Network problems caused recognition to fail.



> Not supported in Windows 8 apps and Windows Phone apps.

### -field MicrophoneUnavailable:10
Lack of a microphone caused recognition to fail.



> Not supported in Windows 8 apps and Windows Phone apps.


## -remarks
[RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) and [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md) return a [SpeechRecognitionResult](speechrecognitionresult.md) object.

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync_1901700993.md) returns a [SpeechRecognitionCompilationResult](speechrecognitioncompilationresult.md) object.


## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
