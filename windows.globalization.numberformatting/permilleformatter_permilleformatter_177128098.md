---
-api-id: M:Windows.Globalization.NumberFormatting.PermilleFormatter.#ctor(Windows.Foundation.Collections.IIterable{System.String},System.String)
-api-type: winrt method
---

<!-- Method syntax
public PermilleFormatter(Windows.Foundation.Collections.IIterable<System.String> languages, System.String geographicRegion)
-->

# Windows.Globalization.NumberFormatting.PermilleFormatter.PermilleFormatter

## -description
Creates a [PermilleFormatter](permilleformatter.md) object initialized by a language list and a geographic region.

## -parameters
### -param languages
The list of language identifiers, in priority order, representing the choice of languages. See Remarks.

### -param geographicRegion
The identifier for the geographic region.

## -remarks
If your app passes language tags used in this class to any [National Language Support](https://docs.microsoft.com/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](https://docs.microsoft.com/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

**Starting in :** Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](http://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that the "nu-" extension can affect the numeral system used by [PermilleFormatter](permilleformatter.md) objects.

## -examples

## -see-also
[Unicode Key/Type Definitions](http://www.unicode.org/reports/tr35/#Key_Type_Definitions)
