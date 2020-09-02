---
-api-id: P:Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.SpeakingRate
-api-type: winrt property
---

<!-- Property syntax.
public double SpeakingRate { get;  set; }
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.SpeakingRate

## -description

Gets or sets the tempo (including pauses and hesitations) of the speech synthesis utterance.

## -property-value

The tempo, relative to the default rate of the selected speech synthesis engine (voice).

This value can range from 0.5 (half the default rate) to 6.0 (6x the default rate), inclusive. The default value is 1.0 (the "normal" speaking rate for the current voice).

Some voices have minimum speaking rates faster than 0.5 and maximum speaking rates slower than 6.0.  

> [!NOTE]
> Speaking rate cannot be directly translated to words-per-minute because each voice and language can have a different default speaking rate.

## -remarks

If Speech Synthesis Markup Language (SSML) is used, SpeakingRate is combined with any prosody tags in the markup.

> [!NOTE]
> Prosody are properties of syllables and larger units of speech, not individual phonetic segments (vowels and consonants).

By default, approximately 750ms of silence is appended after each utterance and each punctuation mark to ensure the utterance sounds as natural as possible. In some cases, such as accelerated playback or screen-reader descriptions of app content, this behavior is not required or needs to be configurable by the user. For more info, see [AppendedSilence](speechsynthesizeroptions_appendedsilence.md) and [PunctuationSilence](speechsynthesizeroptions_punctuationsilence.md).

## -see-also

[PunctuationSilence](speechsynthesizeroptions_punctuationsilence.md), [AppendedSilence](speechsynthesizeroptions_appendedsilence.md), [Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)

## -examples
