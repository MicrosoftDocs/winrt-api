---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognizer.CurrentLanguage
-api-type: winrt property
---

<!-- Property syntax
public Windows.Globalization.Language CurrentLanguage { get; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.CurrentLanguage

## -description
Gets the language used for speech recognition.

## -property-value
The language used for speech recognition.

## -remarks
CurrentLanguage is initialized with the value specified in the [SpeechRecognizer(language)](speechrecognizer_speechrecognizer_938933992.md) constructor. If no language is specified in the [SpeechRecognizer()](speechrecognizer_speechrecognizer_1221375020.md) constructor, CurrentLanguage is initialized with the value of [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md).


## -examples

## -see-also
[SupportedGrammarLanguages](speechrecognizer_supportedgrammarlanguages.md), [SupportedTopicLanguages](speechrecognizer_supportedtopiclanguages.md), [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
