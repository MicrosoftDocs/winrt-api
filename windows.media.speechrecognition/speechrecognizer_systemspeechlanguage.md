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

If no language is specified in the [SpeechRecognizer()](speechrecognizer_speechrecognizer_1221375020.md) constructor, [CurrentLanguage](speechrecognizer_currentlanguage.md) is initialized with the value of [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md).

## -examples

## -see-also
[SpeechRecognizer(Language)](speechrecognizer_speechrecognizer_938933992.md), [CurrentLanguage](speechrecognizer_currentlanguage.md), [SupportedGrammarLanguages](speechrecognizer_supportedgrammarlanguages.md), [SupportedTopicLanguages](speechrecognizer_supportedtopiclanguages.md), [Speech interactions](https://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](https://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
