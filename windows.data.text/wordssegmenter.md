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
A segmenter class that is able to segment provided text into words.

The language supplied when this object is constructed is matched against the languages with word breakers on the system, and the best word segmentation rules available are used. The language need not be one of the app's supported languages. If there are no supported language rules available specifically for that language, the language-neutral rules are used (an implementation of [Unicode Standard Annex #29 Unicode Text Segmentation](http://go.microsoft.com/fwlink/p/?LinkId=325425)), and the [ResolvedLanguage](selectablewordssegmenter_resolvedlanguage.md) property is set to "und" (undetermined language).

## -remarks

## -examples

## -see-also
