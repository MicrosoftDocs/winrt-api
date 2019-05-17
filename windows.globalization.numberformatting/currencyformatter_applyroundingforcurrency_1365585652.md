---
-api-id: M:Windows.Globalization.NumberFormatting.CurrencyFormatter.ApplyRoundingForCurrency(Windows.Globalization.NumberFormatting.RoundingAlgorithm)
-api-type: winrt method
---

<!-- Method syntax
public void ApplyRoundingForCurrency(Windows.Globalization.NumberFormatting.RoundingAlgorithm roundingAlgorithm)
-->

# Windows.Globalization.NumberFormatting.CurrencyFormatter.ApplyRoundingForCurrency

## -description
Prepares the [CurrencyFormatter](currencyformatter.md) object to format currency values with a specified rounding algorithm.

## -parameters
### -param roundingAlgorithm
The desired rounding algorithm for the currency. This must be one of the members of [RoundingAlgorithm](roundingalgorithm.md), excluding **None**.

## -remarks
ApplyRoundingForCurrency initializes [NumberRounder](currencyformatter_numberrounder.md) to an [IncrementNumberRounder](incrementnumberrounder.md) object whose increment is set such that the inputs to [Format](currencyformatter_format_339880429.md) will be rounded to the number of fraction digits established by [Currency](currencyformatter_currency.md). The number of fraction digits can be obtained from the default value of the [FractionDigits](currencyformatter_fractiondigits.md) property.

## -examples

## -see-also
[RoundingAlgorithm](roundingalgorithm.md)
