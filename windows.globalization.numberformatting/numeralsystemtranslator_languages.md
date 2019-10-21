---
-api-id: P:Windows.Globalization.NumberFormatting.NumeralSystemTranslator.Languages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> Languages { get; }
-->

# Windows.Globalization.NumberFormatting.NumeralSystemTranslator.Languages

## -description
Gets the [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) language tag(s) used to initialize this [NumeralSystemTranslator](numeralsystemtranslator.md) object.

## -property-value
The [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) language tag(s) used to initialize this [NumeralSystemTranslator](numeralsystemtranslator.md) object. There is always at least one.

## -remarks
If your app passes language tags used in this class to any [National Language Support](https://docs.microsoft.com/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](https://docs.microsoft.com/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
[BCP-47 language tags](https://go.microsoft.com/fwlink/p/?linkid=227302)
