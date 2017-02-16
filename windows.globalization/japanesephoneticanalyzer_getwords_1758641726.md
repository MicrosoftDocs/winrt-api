---
-api-id: M:Windows.Globalization.JapanesePhoneticAnalyzer.GetWords(System.String,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Globalization.JapanesePhoneme> GetWords(System.String input, System.Boolean monoRuby)
-->

# Windows.Globalization.JapanesePhoneticAnalyzer.GetWords

## -description
Reads a Japanese string that is a combination of Kanji characters and Hiragana characters, and returns a collection of proper readings from the string with word breaks. Optionally uses the "Mono Ruby" strategy in breaking multi-Kanji words into multiple Kanji words.

## -parameters
### -param input
A Japanese string that is a combination of Kanji characters and Hiragana characters.

### -param monoRuby
Specifies the use of the word-breaking strategy "Mono Ruby". If **true**, the word-breaking strategy "Mono Ruby" is used. "Mono Ruby" more aggressively attempts to break multi-Kanji words into multiple Kanji words.

If **false**, "Mono Ruby" is not used.

## -returns
A collection of [JapanesePhoneme](japanesephoneme.md) objects that represent proper readings from the string with word breaks.

## -remarks

## -examples

## -see-also
[JapanesePhoneme](japanesephoneme.md), [GetWords(String)](japanesephoneticanalyzer_getwords_1967945274.md)