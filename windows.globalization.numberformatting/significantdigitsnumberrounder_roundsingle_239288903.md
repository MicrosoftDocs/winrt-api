---
-api-id: M:Windows.Globalization.NumberFormatting.SignificantDigitsNumberRounder.RoundSingle(System.Single)
-api-type: winrt method
---

<!-- Method syntax
public float RoundSingle(System.Single value)
-->

# Windows.Globalization.NumberFormatting.SignificantDigitsNumberRounder.RoundSingle

## -description
Rounds a **Single** number to the specified number of significant digits.

## -parameters
### -param value
The **Single** value to be rounded.

## -returns
The rounded number. This result is a single precision floating point number, which is not necessarily an integer.

## -remarks
The rounding strategy is based on the values of [SignificantDigits](significantdigitsnumberrounder_significantdigits.md) and [RoundingAlgorithm](significantdigitsnumberrounder_roundingalgorithm.md).

> [!NOTE]
> This method is precise only within the limits of the **Single** data type: approximately 7 digits.

## -examples

## -see-also
