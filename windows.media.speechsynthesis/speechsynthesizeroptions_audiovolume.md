---
-api-id: P:Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.AudioVolume
-api-type: winrt property
---

<!-- Property syntax.
public double AudioVolume { get;  set; }
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.AudioVolume

## -description

Gets or sets the loudness of the speech synthesis utterance.

## -property-value

The loudness of the selected speech synthesis engine (voice).

This value can range from 0.0 (lowest volume) to 1.0 (highest volume), inclusive. The default value is 1.0.

## -remarks

If Speech Synthesis Markup Language (SSML) is used, [AudioVolume](speechsynthesizeroptions_audiovolume.md) is combined with prosody tags in the markup.

> [!NOTE]
> Prosody are properties of syllables and larger units of speech, not individual phonetic segments (vowels and consonants).

## -see-also

[Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)

## -examples
