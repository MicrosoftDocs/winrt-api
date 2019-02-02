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
If your app passes language tags used in this class to any [National Language Support](https://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](https://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

## -examples

## -see-also
[BCP-47 language tags](https://go.microsoft.com/fwlink/p/?linkid=227302)
