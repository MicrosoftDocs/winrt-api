---
-api-id: P:Windows.Globalization.NumberFormatting.IncrementNumberRounder.Increment
-api-type: winrt property
---

<!-- Property syntax
public double Increment { get;  set; }
-->

# Windows.Globalization.NumberFormatting.IncrementNumberRounder.Increment

## -description
Gets or sets the increment this [IncrementNumberRounder](incrementnumberrounder.md) object uses for rounding.

## -property-value
The increment used for rounding.

## -remarks

This property can be one of the following:

+ An integer greater than 0.
+ A fraction of the form 1/n, where n is an integer between 2 and 10000000000, inclusive.
+ 1.0e-11, 1.0e-12, 1.0e-13, 1.0e-14, 1.0e-15, 1.0e-16, 1.0e-17, 1.0e-18, 1.0e-19, or 1.0e-20.


This property is initialized to a default value of 1.

When rounding is performed, the result is produced in this manner:
1. Divide the input by the [Increment](incrementnumberrounder_increment.md).
1. Round the result to an integer using the rounding strategy of [RoundingAlgorithm](incrementnumberrounder_roundingalgorithm.md).
1. Multiply the result by the [Increment](incrementnumberrounder_increment.md).


## -examples

## -see-also
