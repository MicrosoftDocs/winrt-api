---
-api-id: P:Windows.Globalization.NumberFormatting.PercentFormatter.ResolvedLanguage
-api-type: winrt property
---

<!-- Property syntax
public string ResolvedLanguage { get; }
-->

# Windows.Globalization.NumberFormatting.PercentFormatter.ResolvedLanguage

## -description

Gets the language that was most recently used to format or parse percent values.

## -property-value

The language from the [priority list of language identifiers](percentformatter_languages.md) that was most recently used to format or parse percent values.

## -remarks

If your app passes language tags from this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the numeral system used by [PercentFormatter(IIterable(String), String)](percentformatter_percentformatter_177128098.md) objects.

## -examples

## -see-also
