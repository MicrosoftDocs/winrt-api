---
-api-id: M:Windows.Globalization.NumberFormatting.CurrencyFormatter.#ctor(System.String,Windows.Foundation.Collections.IIterable{System.String},System.String)
-api-type: winrt method
---

<!-- Method syntax
public CurrencyFormatter(System.String currencyCode, Windows.Foundation.Collections.IIterable<System.String> languages, System.String geographicRegion)
-->

# Windows.Globalization.NumberFormatting.CurrencyFormatter.CurrencyFormatter

## -description
Creates a [CurrencyFormatter](currencyformatter.md) object initialized with a currency identifier, language list, and geographic region.

## -parameters
### -param currencyCode
The currency identifier to use when formatting and parsing currency values.

### -param languages
The list of language identifiers, in priority order, representing the choice of languages. See Remarks.

### -param geographicRegion
The identifier for the geographic region.

## -remarks
In the case that the symbol for the provided currency is the same symbol as that of a different currency in the provided region (or the home region if none is provided), formatting may use a currency code even if the [Mode](currencyformatter_mode.md) property is **UseSymbol**. This is to avoid ambiguity. For example, [CurrencyFormatter](currencyformatter_currencyformatter_1781948400.md) ("USD", ["en"], "CA") creates a formatter that formats 3 as 3 CAD, even if the [Mode](currencyformatter_mode.md) property is **UseSymbol**. Similarly, [CurrencyFormatter](currencyformatter_currencyformatter_1781948400.md) ("CAD", ["en"], "US") creates a formatter that formats 3 as 3 USD.

If your app passes language tags used in this class to any [National Language Support](http://msdn.microsoft.com/library/7a548074-0782-45e1-8051-80c3b9d81885) functions, it must first convert the tags by calling [ResolveLocaleName](http://msdn.microsoft.com/library/99264b22-3fb5-47e2-b0b9-42a6768e67c1).

**Starting in :** Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](http://go.microsoft.com/fwlink/p/?LinkId=308919).) Note that the "nu-" extension can affect the numeral system used by [CurrencyFormatter](currencyformatter.md) objects.

## -examples

## -see-also
[CurrencyFormatter(String)](currencyformatter_currencyformatter_290278668.md), [Unicode Key/Type Definitions](http://go.microsoft.com/fwlink/p/?LinkId=308919)