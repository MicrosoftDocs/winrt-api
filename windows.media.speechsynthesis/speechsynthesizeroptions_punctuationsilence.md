---
-api-id: P:Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.PunctuationSilence
-api-type: winrt property
---

<!-- Property syntax.
public SpeechPunctuationSilence PunctuationSilence { get;  set; }
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.PunctuationSilence

## -description
Gets or sets the amount of silence added after punctuation in the speech synthesis utterance (before another utterance begins).

## -property-value
The [SpeechPunctuationSilence](speechpunctuationsilence.md) duration.

## -remarks
By default, approximately 750ms of silence is appended after each punctuation mark to ensure the utterance sounds as natural as possible. In some cases, such as accelerated playback or screen-reader descriptions of app content, this behavior is not required or needs to be configurable by the user.

## -see-also
[AppendedSilence](speechsynthesizeroptions_appendedsilence.md), [SpeakingRate](speechsynthesizeroptions_speakingrate.md), [Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)

## -examples

