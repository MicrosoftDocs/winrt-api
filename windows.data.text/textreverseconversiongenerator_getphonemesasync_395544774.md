---
-api-id: M:Windows.Data.Text.TextReverseConversionGenerator.GetPhonemesAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Data.Text.TextPhoneme>> GetPhonemesAsync(System.String input)
-->

# Windows.Data.Text.TextReverseConversionGenerator.GetPhonemesAsync

## -description
Returns a set of phonemes representing the given input string. This method is primarily intended for use in sorting data in the Japanese language. Phonetic reading is important for Japanese data handling, especially to sort names in proper phonetic order rather than in character code point order.

Proper names in Japanese that sound the same when pronounced can be spelled in different ways in Kanji. The point of sorting by phonemes is to sort all of the different Kanji spellings of a given proper name to be next to each other in a sorted list, rather than sorting them by character code point and having the various spellings not sorting next to each other.

## -parameters
### -param input
A string containing words in Japanese.

## -returns
On successful completion of the async operation, a list of [TextPhoneme](textphoneme.md) objects representing the input string in phoneme form.

## -remarks

Each [TextPhoneme](textphoneme.md) in the result list has the following properties.

+ The [DisplayText](textphoneme_displaytext.md) always matches a segment of the input string.
+ For Japanese input, the [ReadingText](textphoneme_readingtext.md) is the Hiragana-based reading of the display text.
+ If the system cannot generate a reading, then it reports the [ReadingText](textphoneme_readingtext.md) as being the same as the [DisplayText](textphoneme_displaytext.md).


## -examples

## -see-also
