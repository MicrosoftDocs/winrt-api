---
-api-id: T:Windows.Media.SpeechSynthesis.SpeechSynthesizer
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechSynthesizer : Windows.Foundation.IClosable, Windows.Media.SpeechSynthesis.ISpeechSynthesizer, Windows.Media.SpeechSynthesis.ISpeechSynthesizer2
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizer

## -description

Provides access to the functionality of an installed speech synthesis engine (voice) for Text-to-speech (TTS) services.

## -remarks

Only Microsoft-signed voices installed on the system can be used to generate speech.

Windows includes various Microsoft-signed voices that can be used for a number of languages. Each voice generates synthesized speech in a single language, as spoken in a specific country/region.

By default, a new SpeechSynthesizer object uses the current system voice (call [DefaultVoice](speechsynthesizer_defaultvoice.md) to find out what the default voice is).

To specify any of the other speech synthesis (text-to-speech) voices installed on the user's system, use the [Voice](speechsynthesizer_voice.md) method (to find out which [voices](voiceinformation.md) are installed on the system, call [AllVoices](speechsynthesizer_allvoices.md)).

If you don't specify a language, the voice that most closely corresponds to the language selected in the Language control panel is loaded.

Use a SpeechSynthesizer object to:

- Generate speech from plain text using [SynthesizeTextToStreamAsync](speechsynthesizer_synthesizetexttostreamasync_2010301348.md), or [Speech Synthesis Markup Language (SSML) Version 1.1](https://www.w3.org/TR/speech-synthesis/) using [SynthesizeSsmlToStreamAsync](speechsynthesizer_synthesizessmltostreamasync_1873155127.md) (
- The generated audio stream is played through a [MediaElement](../windows.ui.xaml.controls/mediaelement.md) object), which lets you manage all media playback.
- Control the speech output with the various [SpeechSynthesizerOptions](speechsynthesizeroptions.md) settings exposed through [SpeechSynthesizer.Options](speechsynthesizer_options.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Options |
| 1709 | 16299 | TrySetDefaultVoiceAsync |

## -examples

The following example shows how to generate a speech audio stream from a basic text string.

```csharp
// The media object for controlling and playing audio.
MediaElement mediaElement = this.media;

// The object for controlling the speech synthesis engine (voice).
var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();

// Generate the audio stream from plain text.
SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Hello World");

// Send the stream to the media object.
mediaElement.SetSource(stream, stream.ContentType);
mediaElement.Play();
```

[!code-cpp[SpeechSynthesizerText](../windows.media.speechsynthesis/code/SpeechSynthesis/cpp/MainPage.xaml.cpp#SnippetSpeechSynthesizerText)]

This example shows how to generate a speech audio stream from an SSML string, which includes some modulation elements that control the pitch, speaking rate, and volume of the speech output.

```csharp
// The string to speak with SSML customizations.
string Ssml =
    @"<speak version='1.0' " +
    "xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='en-US'>" +
    "Hello <prosody contour='(0%,+80Hz) (10%,+80%) (40%,+80Hz)'>World</prosody> " + 
    "<break time='500ms'/>" +
    "Goodbye <prosody rate='slow' contour='(0%,+20Hz) (10%,+30%) (40%,+10Hz)'>World</prosody>" +
    "</speak>";

// The media object for controlling and playing audio.
MediaElement mediaElement = this.media;

// The object for controlling the speech synthesis engine (voice).
var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();

// Generate the audio stream from plain text.
SpeechSynthesisStream stream = await synth.synthesizeSsmlToStreamAsync(Ssml);

// Send the stream to the media object.
mediaElement.SetSource(stream, stream.ContentType);
mediaElement.Play();
```

[!code-cpp[SpeechSynthesizerSSML](../windows.media.speechsynthesis/code/SpeechSynthesis/cpp/MainPage.xaml.cpp#SnippetSpeechSynthesizerSSML)]

## -see-also

[Windows.Media.SpeechSynthesis](windows_media_speechsynthesis.md), [IClosable](../windows.foundation/iclosable.md), [VoiceInformation](voiceinformation.md), [Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis), [Holographic voice input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicVoiceInput)
