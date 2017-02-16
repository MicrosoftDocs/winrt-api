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

Constraints, or grammars, define the spoken words and phrases that can be matched by the speech recognizer. You can specify one of the pre-defined, web-service grammars or you can create a custom grammar that is installed with your app.

Predefined dictation and web-search grammars provide speech recognition for your app without requiring you to author a grammar. When using these grammars, speech recognition is performed by a remote web service and the results are returned to the device

## -property-value
The collection of languages supported by the pre-defined, web-service grammars.

## -remarks

## -examples

## -see-also
[SpeechRecognizer(Language)](speechrecognizer_speechrecognizer_938933992.md), [CurrentLanguage](speechrecognizer_currentlanguage.md), [SupportedGrammarLanguages](speechrecognizer_supportedgrammarlanguages.md), [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)