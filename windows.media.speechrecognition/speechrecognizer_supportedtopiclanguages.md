---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognizer.SupportedTopicLanguages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Globalization.Language> SupportedTopicLanguages { get; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.SupportedTopicLanguages

## -description
Gets the collection of languages supported by the pre-defined, web-service grammars of the [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md) objects specified in the [Constraints](speechrecognizer_constraints.md) property.

## -property-value
The collection of languages supported by the pre-defined, web-service grammars.

## -remarks
Constraints, or grammars, define the spoken words and phrases that can be matched by the speech recognizer. You can specify one of the pre-defined, web-service grammars or you can create a custom grammar that is installed with your app.

Predefined dictation and web-search grammars provide speech recognition for your app without requiring you to author a grammar. When using these grammars, speech recognition is performed by a remote web service and the results are returned to the device


## -examples

## -see-also
[SpeechRecognizer(Language)](speechrecognizer_speechrecognizer_938933992.md), [CurrentLanguage](speechrecognizer_currentlanguage.md), [SupportedGrammarLanguages](speechrecognizer_supportedgrammarlanguages.md), [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
