---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognizer.Constraints
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Media.SpeechRecognition.ISpeechRecognitionConstraint> Constraints { get; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.Constraints

## -description

Gets the collection of constraint objects currently added to the [SpeechRecognizer](speechrecognizer.md) object.

## -property-value

A collection of [ISpeechRecognitionConstraint](ispeechrecognitionconstraint.md) objects.

Valid constraint objects include:

+ [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md)
+ [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md)
+ [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md)
+ [SpeechRecognitionVoiceCommandDefinitionConstraint](speechrecognitionvoicecommanddefinitionconstraint.md)

Each speech recognizer can have one constraint collection. Only these combinations of constraints are valid:

+ A single [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md) (dictation or web search)
+ Any combination of [SpeechRecognitionListConstraint](speechrecognitionlistconstraint.md) and/or [SpeechRecognitionGrammarFileConstraint](speechrecognitiongrammarfileconstraint.md) objects.
+ For Windows 10 Fall Creators Update (10.0.16299.15) and newer, a single topic constraint can be combined with a list constraint

> [!Important]
> Call the **[SpeechRecognizer.CompileConstraintsAsync](/uwp/api/windows.media.speechrecognition.speechrecognizer.compileconstraintsasync)** method to compile the constraints before starting the recognition process.

## -remarks

To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -> Privacy -> Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](/windows/uwp/input-and-devices/speech-recognition).

## -examples

## -see-also

[Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
