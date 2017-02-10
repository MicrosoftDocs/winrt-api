---
-api-id: P:Windows.Media.SpeechSynthesis.SpeechSynthesizer.Voice
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.SpeechSynthesis.VoiceInformation Voice { get;  set; }
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizer.Voice

## -description
Gets or sets the speech synthesis engine (voice).

## -property-value
A speech synthesis engine (voice). The default value is the system voice.

## -remarks
Only Microsoft-signed voices can be used by [SpeechSynthesizer](speechsynthesizer.md). Here is a list of Microsoft-signed voices provided with Windows.

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

## -examples

## -see-also
[Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439), [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9), [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)