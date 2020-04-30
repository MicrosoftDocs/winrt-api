---
-api-id: T:Windows.Globalization.NumberFormatting.RoundingAlgorithm
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Globalization.NumberFormatting.RoundingAlgorithm : int
-->

# RoundingAlgorithm

## -description

Specifies the algorithm used to round numbers.

## -enum-fields

### -field None:0

**Do not use.**

### -field RoundDown:1

Round towards negative infinity. (Return the largest integer, increment, or significant digit which does not exceed the input.)

### -field RoundUp:2

Round towards infinity. (Return the smallest integer, increment, or significant digit which is not less than the input.)

### -field RoundTowardsZero:3

Round towards zero. This is the equivalent of **RoundDown** if the input is positive, or **RoundUp** if the input is negative.

### -field RoundAwayFromZero:4

Round away from zero. This is the equivalent of **RoundUp** if the input is positive, or **RoundDown** if the input is negative.

### -field RoundHalfDown:5

Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, this is the equivalent of **RoundDown**.

### -field RoundHalfUp:6

Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, this is the equivalent of **RoundUp**.

### -field RoundHalfTowardsZero:7

Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, this is the equivalent of **RoundTowardsZero**.

### -field RoundHalfAwayFromZero:8

Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, this is the equivalent of **RoundAwayFromZero**.

### -field RoundHalfToEven:9

Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, round to the nearest even output.

### -field RoundHalfToOdd:10

Round to the integer, increment, or significant digit that is closest to the input. If the input is exactly halfway between the possible outputs, round to the nearest odd output.

## -remarks

## -examples

## -see-also

[CurrencyFormatter.ApplyRoundingForCurrency](currencyformatter_applyroundingforcurrency_1365585652.md), [IncrementNumberRounder](incrementnumberrounder.md), [SignificantDigitsNumberRounder](significantdigitsnumberrounder.md), [Number formatting and parsing sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/NumberFormatting)
