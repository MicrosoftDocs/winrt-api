---
-api-id: T:Windows.Media.SpeechRecognition.SpeechRecognitionHypothesis
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechRecognitionHypothesis : Windows.Media.SpeechRecognition.ISpeechRecognitionHypothesis
-->

# Windows.Media.SpeechRecognition.SpeechRecognitionHypothesis

## -description
A recognition result fragment returned by the speech recognizer during an ongoing dictation session.

The result fragment is useful for demonstrating that speech recognition is processing input during a lengthy dictation session.

## -remarks
An app retrieves this object through the [SpeechRecognitionHypothesisGeneratedEventArgs.Hypothesis](speechrecognitionhypothesisgeneratedeventargs_hypothesis.md) property while handling a [HypothesisGenerated](speechrecognizer_hypothesisgenerated.md) event.

## -examples

## -see-also
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
