---
-api-id: T:Windows.Globalization.JapanesePhoneticAnalyzer
-api-type: winrt class
---

<!-- Class syntax.
public class JapanesePhoneticAnalyzer 
-->

# Windows.Globalization.JapanesePhoneticAnalyzer

## -description

Reads a Japanese string that is a combination of Kanji characters and Hiragana characters, and returns a collection of proper readings from the string with word breaks.

## -remarks

Analyzing Japanese strings and generating readings and word breaks is not a straightforward task, as one Kanji character can be read in multiple ways depending on context. Japanese strings also don't have explicit word breaks such as whitespace. JapanesePhoneticAnalyzer breaks an input string into an [IVectorView](https://docs.microsoft.com/previous-versions/br224594(v=vs.85)) of [JapanesePhoneme](japanesephoneme.md) objects.

Each [JapanesePhoneme](japanesephoneme.md) object represents a single Japanese word, and has properties for its display, its "reading" (the pronunciation of the display string, represented by a sequence of Hiragana characters), and whether or not it is the start of a phrase.

**Example**

When the method [JapanesePhoneticAnalyzer.GetWords(input)](japanesephoneticanalyzer_getwords_1967945274.md) analyzes the string "今日はいい天気です", it returns a vector of [JapanesePhoneme](japanesephoneme.md) with these properties:<table>
   <tr><th /><th>0</th><th>1</th><th>2</th><th>3</th><th>4</th></tr>
   <tr><th>[DisplayText](japanesephoneme_displaytext.md)</th><td>今日</td><td>は</td><td>いい</td><td>天気</td><td>です</td></tr>
   <tr><th>[YomiText](japanesephoneme_yomitext.md) (reading)</th><td>きょう</td><td>は</td><td>いい</td><td>てんき</td><td>です</td></tr>
   <tr><th>[IsPhraseStart](japanesephoneme_isphrasestart.md)</th><td>true</td><td>false</td><td>true</td><td>true</td><td>false</td></tr>
</table>

You can also use the method overload [JapanesePhoneticAnalyzer.GetWords(input, monoRuby)](japanesephoneticanalyzer_getwords_1758641726.md) to specify the use of a word-breaking strategy called "Mono Ruby", which more aggressively attempts to break multi-Kanji words into multiple Kanji words. In the above example, using Mono Ruby, "天気" is further broken into "天" and "気". However, "今日" still remains unbroken due to the nature of the Japanese language.

## -examples

## -see-also

[JapanesePhoneme](japanesephoneme.md), [Japanese phonetic analysis sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620555)
