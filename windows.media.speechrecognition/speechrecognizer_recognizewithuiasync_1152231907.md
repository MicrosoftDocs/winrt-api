---
-api-id: M:Windows.Media.SpeechRecognition.SpeechRecognizer.RecognizeWithUIAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.SpeechRecognition.SpeechRecognitionResult> RecognizeWithUIAsync()
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.RecognizeWithUIAsync

## -description
Asynchronously starts a speech recognition session that includes additional UI mechanisms, including prompts, examples, text-to-speech (TTS), and confirmations.

## -returns
The result of the speech recognition session as a [SpeechRecognitionResult](speechrecognitionresult.md) object.

## -remarks
The UI mechanisms supported by RecognizeWithUIAsync are specified by the [UIOptions](speechrecognizer_uioptions.md) property.


## -examples

## -see-also
[RecognizeAsync](speechrecognizer_recognizeasync_748427924.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
