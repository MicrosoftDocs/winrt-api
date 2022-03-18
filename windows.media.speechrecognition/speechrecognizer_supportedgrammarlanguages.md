---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognizer.SupportedGrammarLanguages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Globalization.Language> SupportedGrammarLanguages { get; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.SupportedGrammarLanguages

## -description
Gets the collection of languages supported by the custom grammars of the [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md) and [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md) objects specified in the [Constraints](speechrecognizer_constraints.md) property.

## -property-value
The collection of grammar languages.

## -remarks
Constraints, or grammars, define the spoken words and phrases that can be matched by the speech recognizer. You can specify one of the pre-defined, web-service grammars or you can create a custom grammar, described here, that is installed with your app (speech recognition using a custom constraint is performed on the device).
+ Programmatic list constraints provide a lightweight approach to creating simple grammars using a list of words or phrases. A list constraint works well for recognizing short, distinct phrases. Explicitly specifying all words in a grammar also improves recognition accuracy, as the speech recognition engine must only process speech to confirm a match. The list can also be programmatically updated.
+ A Speech Recognition Grammar Specification (SRGS) grammar is a static document that, unlike a programmatic list constraint, uses the XML format defined by the [ Version 1.0](https://www.w3.org/TR/speech-grammar/). An Speech Recognition Grammar Specification (SRGS) grammar provides the greatest control over the speech recognition experience by letting you capture multiple semantic meanings in a single recognition.

## -examples

## -see-also
[SpeechRecognizer(Language)](speechrecognizer_speechrecognizer_938933992.md), [CurrentLanguage](speechrecognizer_currentlanguage.md), [SupportedTopicLanguages](speechrecognizer_supportedtopiclanguages.md), [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
