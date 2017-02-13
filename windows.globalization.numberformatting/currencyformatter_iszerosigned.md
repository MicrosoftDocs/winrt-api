---
-api-id: P:Windows.Globalization.NumberFormatting.CurrencyFormatter.IsZeroSigned
-api-type: winrt property
---

<!-- Property syntax
public bool IsZeroSigned { get;  set; }
-->

# Windows.Globalization.NumberFormatting.CurrencyFormatter.IsZeroSigned

## -description
Gets or sets whether -0 is formatted using the conventions for negative numbers or for positive numbers. (In the Latin numeral system, the choice is "-0" or "0".)

## -property-value
 **True** if -0 is formatted as a negative number, and **false** if -0 is formatted as a positive number ("-0" or "0" in the Latin numeral system).

## -remarks
You can set this property to specify that [CurrencyFormatter](currencyformatter.md) display negative 0 as "-0". This enables the scenario where you wish to display "-0" when it represents the rounded value of some small negative value (such as -0.00001).

This property defaults to **false** to be consistent with Windows 8 and Windows Server 2012, in which -0 was always formatted as "0".

## -examples

## -see-also
