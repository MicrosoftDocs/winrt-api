---
-api-id: T:Windows.Data.Text.AlternateWordForm
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class AlternateWordForm : Windows.Data.Text.IAlternateWordForm
-->

# Windows.Data.Text.AlternateWordForm

## -description
Identifies an alternate form of the word represented by a [WordSegment](wordsegment.md) object. For example, this may contain a number in a normalized format.

## -remarks
Your code does not create instances of this class. It retrieves them from a [WordSegment.AlternateForms](wordsegment_alternateforms.md) list.

The value of the [AlternateNormalizationFormat](alternatenormalizationformat.md) property indicates the normalization format used to format the [AlternateText](alternatewordform_alternatetext.md) property. It is one of the following possible normalization formats.

When *NormalizationFormat* property is **AlternateNormalizationFormat.Number**, "." is used to indicate the decimal separator, and a leading "-" indicates that the number is negative.

When *NormalizationFormat* is **AlternateNormalizationFormat.Currency**, "." is used to indicate the decimal separator, a leading "-" indicates that the number is negative, and the text following the last digit is the currency symbol.

When *NormalizationFormat* is **AlternateNormalizationFormat.Date**, the result is "YYYY-MM-DD", where "YYYY" is the Gregorian year (0-padded), "MM" is the numerical month (0-padded), and "DD" is the day (0-padded).

When *NormalizationFormat* is **AlternateNormalizationFormat.Time**, the result is "HH:MM:SS", where "HH" is the hour in 24-hour time (0-padded) (0-23), "MM" is the minute (0-padded), and "SS" is the seconds (0-padded).



## -examples

## -see-also
