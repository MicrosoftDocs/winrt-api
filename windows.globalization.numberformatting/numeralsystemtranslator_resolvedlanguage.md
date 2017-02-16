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
The particular [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302) language tag used during the construction of this object to determine the initial value of [NumeralSystem](numeralsystemtranslator_numeralsystem.md).

## -remarks
If your app passes language tags from this class to any [National Language Support](http://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](http://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

## -examples

## -see-also
[NumeralSystem](numeralsystemtranslator_numeralsystem.md), [BCP-47 language tags](http://go.microsoft.com/fwlink/p/?linkid=227302)