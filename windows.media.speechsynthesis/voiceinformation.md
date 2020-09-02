---
-api-id: T:Windows.Media.SpeechSynthesis.VoiceInformation
-api-type: winrt class
---

<!-- Class syntax.
public class VoiceInformation : Windows.Media.SpeechSynthesis.IVoiceInformation
-->

# Windows.Media.SpeechSynthesis.VoiceInformation

## -description
Provides info about an installed speech synthesis engine (voice).

## -remarks

Only Microsoft-signed voices installed on the system can be used to generate speech with a [SpeechSynthesizer](speechsynthesizer.md). Each voice generates synthesized speech in a single language, as spoken in a specific country/region.

Here is a list of Microsoft-signed voices provided with Windows.

<table>
   <tr><th>Voice</th><th>Gender</th><th>Windows 8</th><th>Windows 8.1</th><th>Name</th><th>Display name</th></tr>
   <tr><td>English US</td><td>Female</td><td>Y</td><td>Y</td><td>Zira</td><td>Microsoft Zira (en-US, female).</td></tr>
   <tr><td>English US</td><td>Male</td><td>Y</td><td>Y</td><td>David</td><td>Microsoft David (en-US, male)</td></tr>
   <tr><td>English GB</td><td>Female</td><td>Y</td><td>Y</td><td>Hazel</td><td>Microsoft Hazel (en-GB, female)</td></tr>
   <tr><td>French FR</td><td>Female</td><td>Y</td><td>Y</td><td>Hortense</td><td>Microsoft Hortense (fr-FR , female)</td></tr>
   <tr><td>German DE</td><td>Female</td><td>Y</td><td>Y</td><td>Hedda</td><td>Microsoft Hedda (de-DE, female)</td></tr>
   <tr><td>Spanish ES</td><td>Female</td><td>Y</td><td>Y</td><td>Helena</td><td>Microsoft Helena (es-ES, female)</td></tr>
   <tr><td>Chinese PRC</td><td>Female</td><td>Y</td><td>Y</td><td>Huihui</td><td>Microsoft Huihui (zh-CN, female)</td></tr>
   <tr><td>Chinese TW</td><td>Female</td><td>Y</td><td>Y</td><td>Hanhan</td><td>Microsoft Hanhan (zh-TW, female)</td></tr>
   <tr><td>Japanese JA</td><td>Female</td><td>Y</td><td>Y</td><td>Haruka</td><td>Microsoft Haruka (ja-JP, female)</td></tr>
   <tr><td>Korean KR</td><td>Female</td><td>Y</td><td>Y</td><td>Heami</td><td>Microsoft Heami (ko-KR, female)</td></tr>
   <tr><td>Spanish MX</td><td>Female</td><td>N</td><td>Y</td><td>Sabina</td><td>Microsoft Sabina (es-MX, female)</td></tr>
   <tr><td>Italian IT</td><td>Female</td><td>N</td><td>Y</td><td>Elsa</td><td>Microsoft Elsa (it-IT, female)</td></tr>
   <tr><td>English IN</td><td>Female</td><td>N</td><td>Y</td><td>Heera</td><td>Microsoft Heera (en-IN, female)</td></tr>
   <tr><td>Russian RU</td><td>Female</td><td>N</td><td>Y</td><td>Irina</td><td>Microsoft Irina (ru-RU, female)</td></tr>
   <tr><td>Chinese HK</td><td>Female</td><td>N</td><td>Y</td><td>Tracy</td><td>Microsoft Tracy (zh-HK, female)</td></tr>
   <tr><td>Polish PL</td><td>Female</td><td>N</td><td>Y</td><td>Paulina</td><td>Microsoft Paulina (pl-PL, female)</td></tr>
   <tr><td>Portuguese BR</td><td>Female</td><td>N</td><td>Y</td><td>Maria</td><td>Microsoft Maria (pt-BR, female)</td></tr>
</table>

By default, a new [SpeechSynthesizer](speechsynthesizer.md) object uses the current system voice (call [DefaultVoice](speechsynthesizer_defaultvoice.md) to find out what the default voice is).

To specify any of the other speech synthesis (text-to-speech) voices installed on the user's system, use the [Voice](speechsynthesizer_voice.md) method (to find out which voices are installed on the system, call [AllVoices](speechsynthesizer_allvoices.md)).

If you don't specify a language, the voice that most closely corresponds to the language selected in the Language control panel is loaded.

## -examples

## -see-also

[Windows.Media.SpeechSynthesis](windows_media_speechsynthesis.md), [SpeechSynthesizer](speechsynthesizer.md),[Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
