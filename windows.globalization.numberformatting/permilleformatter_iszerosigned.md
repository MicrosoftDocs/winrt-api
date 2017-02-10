---
-api-id: P:Windows.Globalization.NumberFormatting.PermilleFormatter.IsZeroSigned
-api-type: winrt property
---

<!-- Property syntax
public bool IsZeroSigned { get;  set; }
-->

# Windows.Globalization.NumberFormatting.PermilleFormatter.IsZeroSigned

## -description
Gets or sets whether -0 is formatted as "-0" or "0".

## -property-value
 **True** if -0 is formatted as "-0", and **false** if -0 is formatted as "0".

## -remarks
You can set this property to specify that [PermilleFormatter](permilleformatter.md) display negative 0 as "-0". This enables the scenario where you wish to display "-0" when it represents the rounded value of some small negative value (such as -0.00001).

This property defaults to **false** to be consistent with Windows 8 and Windows Server 2012, in which -0 was always formatted as "0".

## -examples

## -see-also
