---
-api-id: T:Windows.Data.Text.WordsSegmenter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WordsSegmenter : Windows.Data.Text.IWordsSegmenter
-->

# Windows.Data.Text.WordsSegmenter

## -description
A segmenter class that is able to segment provided text into words or word stems (depending on the particular language). 

## -remarks
For languages that do not use spaces between words (such as Japanese, Chinese, Korean, and Thai), use of a segmenter is the only way to obtain individual words for textual processing scenarios such as keyword search.

The language supplied when this object is constructed is matched against the languages with word breakers on the system, and the best word segmentation rules available are used. The language need not be one of the app's supported languages. If there are no supported language rules available specifically for that language, the language-neutral rules are used (an implementation of [Unicode Standard Annex #29 Unicode Text Segmentation](https://www.unicode.org/reports/tr29/)), and the [ResolvedLanguage](selectablewordssegmenter_resolvedlanguage.md) property is set to "und" (undetermined language).

For keyword search scenarios, it is always recommended to request a segmenter in the language of the text contents. 

For spellchecking scenarios, some language segmenters (such as German) may return multiple word stem segments for a single compound word. In contrast, the spellchecking APIs may expect the words to be kept together as a single word. For such languages, you may choose to force language-neutral segmenting rules by explicitly requesting the "und" (undetermined language) segmenter.  However, doing so will greatly reduce the breaking quality of non-spaced languages. Therefore, it is recommended that you use the [Language.Script](/uwp/api/windows.globalization.language.script) API to determine if the content language uses one of the following non-spaced scripts:


| Script | Language |
|--------|----------|
|Bopo|Bopomofo|
|Brah|Brahmi|
|Egyp|Egyptian Hieroglyphs|
|Goth|Gothic|
|Hang|Hangul|
|Hang|Hiragana|
|Hang|Old Hangul|
|Hani|Han|
|Ital|Old Italic|
|Java|Javanese|
|Kana|Katakana|
|Khar|Kharoshthi|
|Khmr|Khmer|
|Laoo|Lao|
|Lisu|Lisu|
|Mymr|Myanmar|
|Talu|New Tai Lue|
|Thai|Thai|
|Tibt|Tibetan|
|Xsux|Cuneiform|
|Yiii|Yi|        

If none of these scripts are found, then it should be safe to use "und" for spellchecking scenario segmentation.

## -examples

## -see-also
