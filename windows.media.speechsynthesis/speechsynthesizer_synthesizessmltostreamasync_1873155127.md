---
-api-id: M:Windows.Media.SpeechSynthesis.SpeechSynthesizer.SynthesizeSsmlToStreamAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.SpeechSynthesis.SpeechSynthesisStream> SynthesizeSsmlToStreamAsync(System.String Ssml)
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizer.SynthesizeSsmlToStreamAsync

## -description

Asynchronously generate and control speech output from a [Speech Synthesis Markup Language (SSML) Version 1.1](https://www.w3.org/TR/speech-synthesis/) string.

## -parameters

### -param Ssml

The SSML-modified text to speak.

## -returns

A [SpeechSynthesisStream](speechsynthesisstream.md) that represents the speech generated from the [Speech Synthesis Markup Language (SSML) Version 1.1](https://www.w3.org/TR/speech-synthesis/).

## -remarks

Voice characteristics, pronunciation, volume, pitch, rate or speed, emphasis, and so on can be customized through [Speech Synthesis Markup Language (SSML) Version 1.1](https://www.w3.org/TR/speech-synthesis/).

To generate speech from plain text, see [SynthesizeTextToStreamAsync](speechsynthesizer_synthesizetexttostreamasync_2010301348.md).

## -examples

## -see-also

[Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
