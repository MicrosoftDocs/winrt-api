---
-api-id: M:Windows.UI.Xaml.GridLengthHelper.FromValueAndType(System.Double,Windows.UI.Xaml.GridUnitType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.GridLength FromValueAndType(System.Double value, Windows.UI.Xaml.GridUnitType type)
-->

# Windows.UI.Xaml.GridLengthHelper.FromValueAndType

## -description
Creates a new [GridLength](gridlength.md) value based on a possible number of pixels, and a [GridUnitType](gridunittype.md). C# and Microsoft Visual Basic code should use [ GridLength(Double,GridUnitType)](gridlength_gridlength_2.md) instead.

## -parameters
### -param value
A numeric value. This might be a pixel height or width to specify, if *type* is specified as **Pixel**, or a factor, if *type* is specified as **Star**. This value is ignored if *type* is specified as **Auto**.

### -param type
A value of the enumeration that specifies which unit type the [GridLength](gridlength.md) represents.

## -returns
The created [GridLength](gridlength.md).

## -remarks

## -examples

## -see-also
