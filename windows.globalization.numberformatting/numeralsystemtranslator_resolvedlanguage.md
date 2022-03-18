---
-api-id: P:Windows.Globalization.NumberFormatting.NumeralSystemTranslator.ResolvedLanguage
-api-type: winrt property
---

<!-- Property syntax
public string ResolvedLanguage { get; }
-->

# Windows.Globalization.NumberFormatting.NumeralSystemTranslator.ResolvedLanguage

## -description
Gets the language used to determine the numeral system when this object was initialized.

## -property-value
The particular [BCP-47](https://tools.ietf.org/html/bcp47) language tag used during the construction of this object to determine the initial value of [NumeralSystem](numeralsystemtranslator_numeralsystem.md).

## -remarks
If your app passes language tags from this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
[NumeralSystem](numeralsystemtranslator_numeralsystem.md), [BCP-47 language tags](https://tools.ietf.org/html/bcp47)
