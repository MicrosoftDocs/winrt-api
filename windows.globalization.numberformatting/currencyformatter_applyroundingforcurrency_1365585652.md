---
-api-id: M:Windows.Globalization.NumberFormatting.CurrencyFormatter.ApplyRoundingForCurrency(Windows.Globalization.NumberFormatting.RoundingAlgorithm)
-api-type: winrt method
---

<!-- Method syntax
public void ApplyRoundingForCurrency(Windows.Globalization.NumberFormatting.RoundingAlgorithm roundingAlgorithm)
-->

# Windows.Globalization.NumberFormatting.CurrencyFormatter.ApplyRoundingForCurrency

## -description

Applies the specified rounding algorithm to the [CurrencyFormatter](currencyformatter.md).

## -parameters

### -param roundingAlgorithm

A value of the [RoundingAlgorithm](roundingalgorithm.md) enumeration.

> [!NOTE]
> [RoundingAlgorithm.None](roundingalgorithm.md) is not a valid value.

## -remarks

ApplyRoundingForCurrency initializes [NumberRounder](currencyformatter_numberrounder.md) to an [IncrementNumberRounder](incrementnumberrounder.md) object whose increment is set such that the inputs to [Format](currencyformatter_format_339880429.md) will be rounded to the number of fraction digits established by [Currency](currencyformatter_currency.md). The number of fraction digits can be obtained from the default value of the [FractionDigits](currencyformatter_fractiondigits.md) property.

## -examples

## -see-also

[RoundingAlgorithm](roundingalgorithm.md)
