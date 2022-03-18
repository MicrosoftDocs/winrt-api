---
-api-id: P:Windows.UI.Xaml.Controls.WrapGrid.ItemHeight
-api-type: winrt property
---

<!-- Property syntax
public double ItemHeight { get;  set; }
-->

# Windows.UI.Xaml.Controls.WrapGrid.ItemHeight

## -description
Gets or sets the height of the layout area for each item that is contained in a [WrapGrid](wrapgrid.md).

Equivalent WinUI property: [Microsoft.UI.Xaml.Controls.WrapGrid.ItemHeight](/windows/winui/api/microsoft.ui.xaml.controls.wrapgrid.itemheight).

## -xaml-syntax
```xaml
<WrapGrid ItemHeight="double" />
```


## -property-value
The height of the layout area for each item that is contained in a [WrapGrid](wrapgrid.md). The default is [Double.NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true), which results in the "Auto" layout behavior.

## -remarks
### "Auto" layout and Double.NaN

The default value of ItemHeight and [ItemWidth](wrapgrid_itemwidth.md) is not 0, it is [Double.NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true). ItemHeight and [ItemWidth](wrapgrid_itemwidth.md) support the ability to be an unset "Auto" value. Because ItemHeight and [ItemWidth](wrapgrid_itemwidth.md) are **Double** values, [Double.NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true) is used as a special value to represent this "Auto" behavior. The layout system interprets the "Auto" value to generally mean that the object should be sized to the available size in layout, instead of to a specific pixel value. If you want the "Auto" behavior for an object when it is used in layout, leave ItemHeight and [ItemWidth](wrapgrid_itemwidth.md) unset at their [Double.NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true) default value. If you have previously set values and want to reenable the "Auto" behavior with run-time code, set to [Double.NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true). In XAML such as templates, you can set attribute values using the string "Auto". 
<!--Setting Auto in XAML is a special behavior of the XAML parser, not a TypeConverter behavior.-->


> [!NOTE]
> Visual C++ component extensions (C++/CX) doesn't have a constant for **NaN**, it uses a value, which appears as "-1.#IND" followed by zeros.

## -examples

## -see-also
[ItemWidth](wrapgrid_itemwidth.md)
