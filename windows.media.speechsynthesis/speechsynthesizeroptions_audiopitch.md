---
-api-id: P:Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.AudioPitch
-api-type: winrt property
---

<!-- Property syntax.
public double AudioPitch { get;  set; }
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizerOptions.AudioPitch

## -description
Gets or sets the tone (relative highness or lowness) of the speech synthesis utterance.

## -property-value
The tone of the selected speech synthesis engine (voice).

This value can range from 0.0 (lowest pitch) to 2.0 (highest pitch), inclusive. The default value is 1.0.

Some voices have a minimum speaking pitch higher than 0.0 and a maximum speaking pitch lower than 2.0.  

## -remarks
If Speech Synthesis Markup Language (SSML) is used, AudioPitch is combined with any prosody tags in the markup.

> [!NOTE]
> Prosody are properties of syllables and larger units of speech, not individual phonetic segments (vowels and consonants).


## -see-also
[Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)

## -examples

