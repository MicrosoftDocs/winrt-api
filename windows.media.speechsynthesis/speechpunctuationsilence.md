---
-api-id: T:Windows.Media.SpeechSynthesis.SpeechPunctuationSilence
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum SpeechPunctuationSilence : int 
-->

# Windows.Media.SpeechSynthesis.SpeechPunctuationSilence

## -description
Specifies the amount of silence added after punctuation in the speech synthesis utterance (before another utterance begins).

## -enum-fields
### -field Min:1
The minimum amount of silence defined by the speech synthesis voice.

### -field Default:0
The default amount of silence defined by the speech synthesis voice.

## -remarks
By default, approximately 750ms of silence is appended after each punctuation mark to ensure the utterance sounds as natural as possible. In some cases, such as accelerated playback or screen-reader descriptions of app content, this behavior is not required or needs to be configurable by the user.

## -see-also
[SpeechSynthesizerOptions.PunctuationSilence](speechsynthesizeroptions_punctuationsilence.md), [SpeakingRate](speechsynthesizeroptions_speakingrate.md), [Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)

## -examples

