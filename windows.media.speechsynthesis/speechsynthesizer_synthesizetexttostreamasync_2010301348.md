---
-api-id: M:Windows.Media.SpeechSynthesis.SpeechSynthesizer.SynthesizeTextToStreamAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.SpeechSynthesis.SpeechSynthesisStream> SynthesizeTextToStreamAsync(System.String text)
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizer.SynthesizeTextToStreamAsync

## -description

Asynchronously generate speech output from a string.

## -parameters

### -param text

The text to speak.

## -returns

A [SpeechSynthesisStream](speechsynthesisstream.md) that represents the speech generated from the text.

## -remarks

To generate speech from [Speech Synthesis Markup Language (SSML) Version 1.1](https://www.w3.org/TR/speech-synthesis/), see [SynthesizeSsmlToStreamAsync](speechsynthesizer_synthesizessmltostreamasync_1873155127.md).

## -examples

## -see-also

[Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
