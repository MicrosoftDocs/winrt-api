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
[Windows.Media.SpeechRecognition](windows_media_speechrecognition.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
