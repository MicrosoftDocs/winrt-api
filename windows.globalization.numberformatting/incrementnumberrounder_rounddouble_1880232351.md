---
-api-id: M:Windows.Globalization.NumberFormatting.IncrementNumberRounder.RoundDouble(System.Double)
-api-type: winrt method
---

<!-- Method syntax
public double RoundDouble(System.Double value)
-->

# Windows.Globalization.NumberFormatting.IncrementNumberRounder.RoundDouble

## -description

Rounds a **Double** number to the specified increment.

## -parameters

### -param value

The **Double** value to be rounded.

## -returns

The rounded number. This result is a double precision floating point number, which is not necessarily an integer.

## -remarks

The rounding strategy is based on the values of [Increment](incrementnumberrounder_increment.md) and [RoundingAlgorithm](incrementnumberrounder_roundingalgorithm.md).

> [!NOTE]
> This method is precise only within the limits of the [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true) data type, or approximately 15 digits.

## -examples

## -see-also
