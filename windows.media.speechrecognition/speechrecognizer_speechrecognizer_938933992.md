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

Asynchronously starts a speech recognition session that includes additional UI mechanisms, including prompts, examples, text-to-speech (TTS), and confirmations.

## -parameters
### -param language
The spoken language to use for recognition.

## -exceptions
### 0x800455bc (SPERR_WINRT_UNSUPPORTED_LANG)

If the specified language is not supported.

## -remarks
[CurrentLanguage](speechrecognizer_currentlanguage.md) is set to the value of *language*.

## -examples

## -see-also
[SpeechRecognizer()](speechrecognizer_speechrecognizer_1221375020.md), [SupportedGrammarLanguages](speechrecognizer_supportedgrammarlanguages.md), [SupportedTopicLanguages](speechrecognizer_supportedtopiclanguages.md), [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)