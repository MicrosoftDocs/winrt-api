---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognizer.Constraints
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint> Constraints { get; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.Constraints

## -description
Gets the collection of constraint objects that are associated with the [SpeechRecognizer](speechrecognizer.md) object.

## -property-value
The [ISpeechRecognitionConstraint](ispeechrecognitionconstraint.md) objects associated with the speech recognizer. 
Valid constraint objects include:

+ [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md)
+ [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md)
+ [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md)
+ [SpeechRecognitionVoiceCommandDefinitionConstraint](speechrecognitionvoicecommanddefinitionconstraint.md)


Only [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md) and [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md) objects can be mixed in the same collection.

## -remarks

## -examples

## -see-also
[Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)