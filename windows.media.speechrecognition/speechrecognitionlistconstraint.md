---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionListConstraint
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechRecognitionListConstraint : Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint, Windows.Media.SpeechRecognition.ISpeechRecognitionListConstraint
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionListConstraint

## -description

A custom grammar constraint based on a list of words or phrases that can be recognized by the [SpeechRecognizer](speechrecognizer.md) object. When initialized, this object is added to the [Constraints](speechrecognizer_constraints.md) collection.

> [!NOTE]
> Speech recognition using a custom constraint is performed on the device.

## -remarks

Constraints, or grammars, define the spoken words and phrases that can be matched by the speech recognizer. You can specify one of the pre-defined, web-service grammars ([SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md)) or you can create a custom grammar, described here, that is installed with your app.

+ Programmatic list constraints (SpeechRecognitionListConstraint) provide a lightweight approach to creating simple grammars using a list of words or phrases. A list constraint works well for recognizing short, distinct phrases. Explicitly specifying all words in a grammar also improves recognition accuracy, as the speech recognition engine must only process speech to confirm a match. The list can also be programmatically updated.
+ A Speech Recognition Grammar Specification (SRGS) grammar ([SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md)) is a static document that, unlike a programmatic list constraint, uses the XML format defined by the [ Version 1.0](https://www.w3.org/TR/speech-grammar/). An Speech Recognition Grammar Specification (SRGS) grammar provides the greatest control over the speech recognition experience by letting you capture multiple semantic meanings in a single recognition.

[CompileConstraintsAsync](speechrecognizer_compileconstraintsasync_1901700993.md) must always be called before [RecognizeAsync](speechrecognizer_recognizeasync_748427924.md) or [RecognizeWithUIAsync](speechrecognizer_recognizewithuiasync_1152231907.md), even if no constraints are specified in the [Constraints](speechrecognizer_constraints.md) property.

> [!NOTE]
> You can use a SpeechRecognitionListConstraint in conjunction with a web service [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md) to increase accuracy during a dictation session by providing a set of domain-specific keywords that you think are likely to be used.

## -examples

## -see-also

[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [SpeechRecognitionConstraintType](speechrecognitionconstrainttype.md), [ISpeechRecognitionConstraint](ispeechrecognitionconstraint.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis), [Holographic voice input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicVoiceInput)
