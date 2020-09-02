---
-api-id: P:Windows.Media.SpeechRecognition.SpeechRecognizer.SystemSpeechLanguage
-api-type: winrt property
---

<!-- Property syntax
public Windows.Globalization.Language SystemSpeechLanguage { get; }
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.SystemSpeechLanguage

## -description
Gets the speech language of the device specified in **Settings &gt; Time &amp; Language &gt; Speech**.

## -property-value
The speech language of the device, or null if a speech language is not installed.

## -remarks
Speech languages are added from the **Settings &gt; Time &amp; Language &gt; Region &amp; language** screen.

1. Click **Add a language**.
1. Select a language from the **Add a language** screen.
1. Depending on the language selected, a language region screen might be displayed. Select the region.
1. From the **Settings &gt; Time &amp; Language &gt; Region &amp; language** screen, select the language and click **Options**.
1. If a speech language is available for the selected language and region, a **Download** button is displayed on the **Language options** screen. Click this button to download and install the speech language.

If no language is specified in the [SpeechRecognizer()](speechrecognizer_speechrecognizer_1221375020.md) constructor, [CurrentLanguage](speechrecognizer_currentlanguage.md) is initialized with the value of SystemSpeechLanguage.

## -examples

## -see-also
[SpeechRecognizer(Language)](speechrecognizer_speechrecognizer_938933992.md), [CurrentLanguage](speechrecognizer_currentlanguage.md), [SupportedGrammarLanguages](speechrecognizer_supportedgrammarlanguages.md), [SupportedTopicLanguages](speechrecognizer_supportedtopiclanguages.md), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
