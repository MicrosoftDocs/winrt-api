---
-api-id: P:Windows.Globalization.NumberFormatting.NumeralSystemTranslator.NumeralSystem
-api-type: winrt property
---

<!-- Property syntax
public string NumeralSystem { get;  set; }
-->

# Windows.Globalization.NumberFormatting.NumeralSystemTranslator.NumeralSystem

## -description
Gets or sets the numeral system that Latin digits will be converted to on calls to [TranslateNumerals](numeralsystemtranslator_translatenumerals_1419744509.md).

## -property-value
A string that indicates the target numeral system of the translator, such as "Arab" for the Arabic-Indic numeral system (٠١٢٣٤٥٦٧٨٩). See the supported [NumeralSystem values](/previous-versions/windows/apps/jj236471(v=win.10)).

## -remarks
> [!NOTE]
> For Arabic numeral systems ("Arab" and "ArabExt" or any numeral systems which use a combination of those characters):+ A period (.) immediately before a Latin digit is converted to the Arabic Decimal Separator (u+66b).
+ A comma (,) immediately before a Latin digit is converted to Arabic Thousand Separator (u+66c).
+ A percent (%) adjacent to a Latin digit is converted to Arabic Per Cent Symbol (u+66a).
+ A permille (u+2030) adjacent to a Latin digit is converted to Arabic Per Mille Symbol (u+609).


## -examples

## -see-also
[NumeralSystem values](/previous-versions/windows/apps/jj236471(v=win.10))
