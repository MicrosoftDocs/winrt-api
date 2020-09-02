---
-api-id: P:Windows.Globalization.DateTimeFormatting.DateTimeFormatter.ResolvedLanguage
-api-type: winrt property
---

<!-- Property syntax
public string ResolvedLanguage { get; }
-->

# Windows.Globalization.DateTimeFormatting.DateTimeFormatter.ResolvedLanguage

## -description
Gets the language that was most recently used to format dates and times.

## -property-value
The language from the [priority list of language identifiers](datetimeformatter_languages.md) that was most recently used to format dates and times.

**Starting in :** Language tags can support Unicode extensions. See the Remarks for the [DateTimeFormatter(String, IIterable(String))](datetimeformatter_datetimeformatter_204585840.md) constructor.

## -remarks
If your app passes language tags from this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

## -examples

## -see-also
