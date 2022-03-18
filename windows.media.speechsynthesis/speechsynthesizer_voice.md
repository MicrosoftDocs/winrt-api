---
-api-id: P:Windows.Media.SpeechSynthesis.SpeechSynthesizer.Voice
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.SpeechSynthesis.VoiceInformation Voice { get;  set; }
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizer.Voice

## -description

Gets or sets the speech synthesis engine (voice).

## -property-value

A speech synthesis engine (or voice). The default value is the current system voice.

## -remarks

Only Microsoft-signed voices installed on the system can be used to generate speech with a [SpeechSynthesizer](speechsynthesizer.md). Each voice generates synthesized speech in a single language, as spoken in a specific country/region.

By default, a new [SpeechSynthesizer](speechsynthesizer.md) object uses the current system voice (call [DefaultVoice](speechsynthesizer_defaultvoice.md) to find out what the default voice is).

To specify any of the other speech synthesis (text-to-speech) voices installed on the user's system, use the Voice method (to find out which [voices](voiceinformation.md) are installed on the system, call [AllVoices](speechsynthesizer_allvoices.md)).

If you don't specify a language, the voice that most closely corresponds to the language selected in the Language control panel is loaded.

## -examples

Here, we show how to select a gender for the voice ([VoiceInformation.Gender](voiceinformation_gender.md)) by using either the first female voice ([VoiceGender](voicegender.md)) found, or just the default system voice ([SpeechSynthesizer.DefaultVoice](speechsynthesizer_defaultvoice.md)), if no female voice is found.

```csharp
using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
{
    VoiceInformation voiceInfo =
        (
            from voice in SpeechSynthesizer.AllVoices
            where voice.Gender == VoiceGender.Female
            select voice
        ).FirstOrDefault() ?? SpeechSynthesizer.DefaultVoice;
        
    synthesizer.Voice = voiceInfo;
    
    // Windows.Media.SpeechSynthesis.SpeechSynthesisStream
    stream = await synthesizer.SynthesizeTextToStreamAsync(text);
}
```

## -see-also

[Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
