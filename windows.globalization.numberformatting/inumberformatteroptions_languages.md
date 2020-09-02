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
If your app passes language tags from this interface to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
