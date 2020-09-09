---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognizerUIOptions.AudiblePrompt
-api-type: winrt property
---

<!-- Property syntax
public string AudiblePrompt { get;  set; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognizerUIOptions.AudiblePrompt

## -description
Gets or sets the heading text that is displayed on the **Listening** screen. The default is "Listening...".

## -property-value
The heading text. A custom string should clearly describe the kind of info expected by the app and is limited to two lines in length.

## -remarks
The default string is automatically localized: If the speech recognizer has an associated language, the default text is shown in that language. Otherwise, the default text is shown in the system language.

You are responsible for localizing a custom string.



## -examples

## -see-also
[Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
