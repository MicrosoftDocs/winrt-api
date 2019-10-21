---
-api-id: P:Windows.Globalization.NumberFormatting.DecimalFormatter.ResolvedLanguage
-api-type: winrt property
---

<!-- Property syntax
public string ResolvedLanguage { get; }
-->

# Windows.Globalization.NumberFormatting.DecimalFormatter.ResolvedLanguage

## -description
Gets the language that was most recently used to format or parse decimal values.

## -property-value
The language from the [priority list of language identifiers](decimalformatter_languages.md) that was most recently used to format or parse decimal values.

**Starting in :** Language tags can support Unicode extensions. See the Remarks for the [DecimalFormatter(IIterable(String), String)](decimalformatter_decimalformatter_177128098.md) constructor.

## -remarks
If your app passes language tags from this class to any [National Language Support](https://docs.microsoft.com/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](https://docs.microsoft.com/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
