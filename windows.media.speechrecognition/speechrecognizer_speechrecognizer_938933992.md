---
-api-id: M:Windows.Media.SpeechRecognition.SpeechRecognizer.#ctor(Windows.Globalization.Language)
-api-type: winrt method
---

<!-- Method syntax
public SpeechRecognizer(Windows.Globalization.Language language)
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.SpeechRecognizer

## -description
Creates a new instance of the [SpeechRecognizer](speechrecognizer.md) class with a language specifier.

## -parameters
### -param language
The spoken language to use for recognition.

## -remarks
Asynchronously starts a speech recognition session that includes additional UI mechanisms, including prompts, examples, text-to-speech (TTS), and confirmations.

[CurrentLanguage](speechrecognizer_currentlanguage.md) is set to the value of *language*.

#### Error codes
##### SPERR_WINRT_UNSUPPORTED_LANG  (0x800455bc)
Thrown if the specified language is not supported.

## -examples

## -see-also
[SpeechRecognizer()](speechrecognizer_speechrecognizer_1221375020.md), [SupportedGrammarLanguages](speechrecognizer_supportedgrammarlanguages.md), [SupportedTopicLanguages](speechrecognizer_supportedtopiclanguages.md), [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
