---
-api-id: M:Windows.Globalization.NumberFormatting.DecimalFormatter.#ctor(Windows.Foundation.Collections.IIterable{System.String},System.String)
-api-type: winrt method
---

<!-- Method syntax
public DecimalFormatter(Windows.Foundation.Collections.IIterable<System.String> languages, System.String geographicRegion)
-->

# Windows.Globalization.NumberFormatting.DecimalFormatter.DecimalFormatter

## -description

Creates a [DecimalFormatter](decimalformatter.md) object initialized by a language list and a geographic region.

## -parameters

### -param languages

The list of language identifiers, in priority order, representing the choice of languages. See Remarks.

### -param geographicRegion

The identifier for the geographic region.

## -remarks

If your app passes language tags used in this class to any [National Language Support](/windows/desktop/Intl/national-language-support) functions, it must first convert the tags by calling [ResolveLocaleName](/windows/desktop/api/winnls/nf-winnls-resolvelocalename).

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the numeral system used by [DecimalFormatter](decimalformatter.md) objects.

## -examples

## -see-also

[Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions)
