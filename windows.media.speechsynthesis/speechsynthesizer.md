---
-api-id: T:Windows.Media.SpeechSynthesis.SpeechSynthesizer
-api-type: winrt class
---

<!-- Class syntax.
public class SpeechSynthesizer : Windows.Foundation.IClosable, Windows.Media.SpeechSynthesis.ISpeechSynthesizer, Windows.Media.SpeechSynthesis.ISpeechSynthesizer2
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizer

## -description

Provides access to the functionality of an installed speech synthesis engine (voice).

Windows includes Microsoft-signed voices that can be used for a variety of languages. Each voice generates synthesized speech in a single language, as spoken in a specific country/region.

Only Microsoft-signed voices installed on the system can be used to generate speech. If no language is specified, the voice that most closely matches the language selected by the user in the Language control panel is loaded.

## -remarks

## -examples

Your UWP app can use a [SpeechSynthesizer](../windows.devices.humaninterfacedevice/hiddevice_getdeviceselector.md) object to create an audio stream and output speech based on a plain text string.

```javascript

// The object for controlling and playing audio.
var audio = new Audio();

// The object for controlling the speech synthesis engine (voice).
var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();

// Generate the audio stream from plain text.
synth.synthesizeTextToStreamAsync("hello World").then(function (markersStream) {

    // Convert the stream to a URL Blob.
    var blob = MSApp.createBlobFromRandomAccessStream(markersStream.ContentType, markersStream);

    // Send the Blob to the audio object.
    audio.src = URL.createObjectURL(blob, { oneTimeOnly: true });
    audio.play();
});
```

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

```javascript

// The string to speak with SSML customizations.
var Ssml = "<speak version='1.0' " +
    "xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='en-US'>" +
    "Hello <prosody contour='(0%,+80Hz) (10%,+80%) (40%,+80Hz)'>World</prosody> " + 
    "<break time='500ms'/>" +
    "Goodbye <prosody rate='slow' contour='(0%,+20Hz) (10%,+30%) (40%,+10Hz)'>World</prosody>" +
    "</speak>";

// The object for controlling and playing audio.
var audio = new Audio();

// The object for controlling the speech synthesis engine (voice).
var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();

// Generate the audio stream from plain text.
synth.synthesizeSsmlToStreamAsync(Ssml).then(function(synthesisStream){

    // Convert the stream to a URL Blob.
    var blob = MSApp.createBlobFromRandomAccessStream(synthesisStream.ContentType, synthesisStream);

    // Send the Blob to the audio object.
    audio.src = URL.createObjectURL(blob, { oneTimeOnly: true });
    audio.play();
});
```

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

[Windows.Media.SpeechSynthesis](windows_media_speechsynthesis.md), [IClosable](../windows.foundation/iclosable.md), [VoiceInformation](voiceinformation.md), [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897), [Holographic voice input sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicVoiceInput)