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
[Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)