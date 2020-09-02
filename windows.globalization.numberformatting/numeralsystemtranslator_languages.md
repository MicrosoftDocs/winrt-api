---
-api-id: P:Windows.Globalization.NumberFormatting.NumeralSystemTranslator.Languages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> Languages { get; }
-->

# Windows.Globalization.NumberFormatting.NumeralSystemTranslator.Languages

## -description
Gets the [BCP-47](https://tools.ietf.org/html/bcp47) language tag(s) used to initialize this [NumeralSystemTranslator](numeralsystemtranslator.md) object.

## -property-value
The [BCP-47](https://tools.ietf.org/html/bcp47) language tag(s) used to initialize this [NumeralSystemTranslator](numeralsystemtranslator.md) object. There is always at least one.

## -remarks
If your app passes language tags used in this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
[BCP-47 language tags](https://tools.ietf.org/html/bcp47)
