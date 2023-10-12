---
-api-id: P:Windows.Globalization.NumberFormatting.PermilleFormatter.Languages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> Languages { get; }
-->

# Windows.Globalization.NumberFormatting.PermilleFormatter.Languages

## -description

Gets the priority list of language identifiers that is used when formatting and parsing permille values.

## -property-value

The priority list of language identifiers.

## -remarks

If your app passes language tags from this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the numeral system used by [PermilleFormatter(IIterable(String), String)](permilleformatter_permilleformatter_177128098.md) objects.

## -examples

## -see-also
