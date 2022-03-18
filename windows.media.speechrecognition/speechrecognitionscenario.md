---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionScenario
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.SpeechRecognition.SpeechRecognitionScenario : int
-->

# SpeechRecognitionScenario

## -description
Specifies the scenario used to optimize speech recognition for a web-service constraint (created through a [SpeechRecognitionTopicConstraint](speechrecognitiontopicconstraint.md) object).

## -enum-fields
### -field WebSearch:0
A grammar constraint optimized for web search recognition scenarios.

### -field Dictation:1
A gramar constraint optimized for continuous recognition scenarios.

### -field FormFilling:2
A grammar constraint optimized for form input recognition scenarios.

## -remarks
To use web-service constraints, speech input and dictation support must be enabled in **Settings** by turning on the "Get to know me" option in the Settings -> Privacy -> Speech, inking, and typing page. See "Recognize speech input" in [Speech recognition](/windows/uwp/input-and-devices/speech-recognition).

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
