---
-api-id: M:Windows.Globalization.JapanesePhoneticAnalyzer.GetWords(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Globalization.JapanesePhoneme> GetWords(System.String input)
-->

# Windows.Globalization.JapanesePhoneticAnalyzer.GetWords

## -description

Reads a Japanese string that is a combination of Kanji characters and Hiragana characters, and returns a collection of proper readings from the string with word breaks.

## -parameters

### -param input

A Japanese string that is a combination of Kanji characters and Hiragana characters.

The maximum length of this string is 100 characters.

## -returns

A collection of [JapanesePhoneme](japanesephoneme.md) objects that represent proper readings from the string with word breaks.

## -remarks

## -examples

## -see-also

[JapanesePhoneme](japanesephoneme.md), [GetWords(String, Boolean)](japanesephoneticanalyzer_getwords_1758641726.md), [Japanese phonetic analysis sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/JapanesePhoneticAnalysis)
