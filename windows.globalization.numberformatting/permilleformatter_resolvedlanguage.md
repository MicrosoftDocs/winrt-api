---
-api-id: P:Windows.Globalization.NumberFormatting.PermilleFormatter.ResolvedLanguage
-api-type: winrt property
---

<!-- Property syntax
public string ResolvedLanguage { get; }
-->

# Windows.Globalization.NumberFormatting.PermilleFormatter.ResolvedLanguage

## -description
Gets the language that was most recently used to format or parse permille values.

## -property-value
The language from the [priority list of language identifiers](permilleformatter_languages.md) that was most recently used to format or parse permille values.

**Starting in :** Language tags can support Unicode extensions. See the Remarks for the [PermilleFormatter(IIterable(String), String)](permilleformatter_permilleformatter_177128098.md) constructor.

## -remarks
If your app passes language tags from this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
