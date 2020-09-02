---
-api-id: P:Windows.Globalization.NumberFormatting.INumberFormatterOptions.ResolvedLanguage
-api-type: winrt property
---

<!-- Property syntax
public string ResolvedLanguage { get; }
-->

# Windows.Globalization.NumberFormatting.INumberFormatterOptions.ResolvedLanguage

## -description
Gets the language that was most recently used to format or parse numbers.

## -property-value
The language from the [priority list of language identifiers](inumberformatteroptions_languages.md) that was most recently used to format or parse numbers.

## -remarks
If your app passes language tags from this interface to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
