---
-api-id: P:Windows.Globalization.NumberFormatting.SignificantDigitsNumberRounder.SignificantDigits
-api-type: winrt property
---

<!-- Property syntax
public uint SignificantDigits { get;  set; }
-->

# Windows.Globalization.NumberFormatting.SignificantDigitsNumberRounder.SignificantDigits

## -description
Gets or sets the number of significant digits this [SignificantDigitsNumberRounder](significantdigitsnumberrounder.md) object uses for rounding.

## -property-value
The number of significant digits used for rounding.

## -remarks
This property is initialized to a default value of 1.

If this property is 0, no rounding is performed by the [SignificantDigitsNumberRounder](significantdigitsnumberrounder.md) object.

When rounding is performed, leading 0s in the input are not considered. Significant digits are counted beginning with the first non-zero digit until the number of [SignificantDigits](significantdigitsnumberrounder_significantdigits.md) occurs, and then [RoundingAlgorithm](significantdigitsnumberrounder_roundingalgorithm.md) is used to round at that position.

## -examples

## -see-also
