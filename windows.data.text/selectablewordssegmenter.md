---
-api-id: T:Windows.Data.Text.SelectableWordsSegmenter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SelectableWordsSegmenter : Windows.Data.Text.ISelectableWordsSegmenter
-->

# Windows.Data.Text.SelectableWordsSegmenter

## -description
A segmenter class that is able to segment provided text into units appropriate for selecting text by words.

The language supplied when this object is constructed is matched against the languages with word breakers on the system, and the best word segmentation rules available are used. The language need not be one of the app's supported languages. If there are no supported language rules available specifically for that language, the language-neutral rules are used (an implementation of [Unicode Standard Annex #29 Unicode Text Segmentation](https://www.unicode.org/reports/tr29/)), and the [ResolvedLanguage](selectablewordssegmenter_resolvedlanguage.md) property is set to "und" (undetermined language).

## -remarks

## -examples

## -see-also
