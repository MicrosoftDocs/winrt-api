---
-api-id: M:Windows.Globalization.NumberFormatting.NumeralSystemTranslator.TranslateNumerals(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string TranslateNumerals(System.String value)
-->

# Windows.Globalization.NumberFormatting.NumeralSystemTranslator.TranslateNumerals

## -description
Converts a string of characters containing Latin digits to a string containing the corresponding digits of [NumeralSystem](numeralsystemtranslator_numeralsystem.md).

## -parameters
### -param value
A string of characters containing Latin digits to be converted.

## -returns
A string containing the converted digits. This string may be a different length than *value*.

## -remarks
Characters in *value* that are not Latin digits are not converted, but pass through unchanged. If *value* is **null** (representing an empty string) the result is **null**. If [NumeralSystem](numeralsystemtranslator_numeralsystem.md) is "Latn", *value* is passed through unchanged.

> [!NOTE]
> For Arabic numeral systems ("Arab" and "ArabExt" or any numeral systems which use a combination of those characters):+ A period (.) immediately before a Latin digit is converted to the Arabic Decimal Separator (u+66b).
+ A comma (,) immediately before a Latin digit is converted to Arabic Thousand Separator (u+66c).
+ A percent (%) adjacent to a Latin digit is converted to Arabic Per Cent Symbol (u+66a).
+ A permille (u+2030) adjacent to a Latin digit is converted to Arabic Per Mille Symbol (u+609).


## -examples

## -see-also
[NumeralSystem](numeralsystemtranslator_numeralsystem.md)