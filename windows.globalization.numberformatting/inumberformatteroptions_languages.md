---
-api-id: P:Windows.Globalization.NumberFormatting.INumberFormatterOptions.Languages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> Languages { get; }
-->

# Windows.Globalization.NumberFormatting.INumberFormatterOptions.Languages

## -description
Gets the priority list of language identifiers that is used when formatting and parsing numbers.

## -property-value
The priority list of language identifiers.

## -remarks
If your app passes language tags from this interface to any [National Language Support](https://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](https://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

## -examples

## -see-also
