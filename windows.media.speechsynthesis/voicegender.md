---
-api-id: T:Windows.Media.SpeechSynthesis.VoiceGender
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.SpeechSynthesis.VoiceGender : int
-->

# VoiceGender

## -description

Specifies the gender preferences available for speech synthesis (if supported by the specified speech synthesis engine).

## -enum-fields

### -field Male:0

Male

### -field Female:1

Female

## -remarks

## -examples

Here, we show how to select a gender for the voice ([VoiceInformation.Gender](voiceinformation_gender.md)) by using either the first female voice (VoiceGender) found, or just the default system voice ([SpeechSynthesizer.DefaultVoice](speechsynthesizer_defaultvoice.md)), if no female voice is found.

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

[Windows.Media.SpeechSynthesis](windows_media_speechsynthesis.md), [Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
