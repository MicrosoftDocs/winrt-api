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
[CurrentLanguage](speechrecognizer_currentlanguage.md) is initialized with the value specified in the [SpeechRecognizer(language)](speechrecognizer_speechrecognizer_938933992.md) constructor. If no language is specified in the [SpeechRecognizer()](speechrecognizer_speechrecognizer_1221375020.md) constructor, [CurrentLanguage](speechrecognizer_currentlanguage.md) is initialized with the value of [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md).


## -examples

## -see-also
[SupportedGrammarLanguages](speechrecognizer_supportedgrammarlanguages.md), [SupportedTopicLanguages](speechrecognizer_supportedtopiclanguages.md), [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md), [Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
