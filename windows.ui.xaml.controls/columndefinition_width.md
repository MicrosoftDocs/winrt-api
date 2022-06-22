---
-api-id: P:Windows.UI.Xaml.Controls.ColumnDefinition.Width
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.GridLength Width { get;  set; }
-->

# Windows.UI.Xaml.Controls.ColumnDefinition.Width

## -description
Gets the calculated width of a [ColumnDefinition](columndefinition.md) element, or sets the [GridLength](../windows.ui.xaml/gridlength.md) value of a column that is defined by the [ColumnDefinition](columndefinition.md).



## -xaml-syntax
```xaml
<ColumnDefinition Width="doubleValue"/>
- or -
<ColumnDefinition Width="starSizing"/>
-or-
<ColumnDefinition Width="Auto"/>
```


## -xaml-values
<dl><dt>doubleValue</dt><dd>doubleValueThe column's width, expressed as a floating-point value for a pixel count. Typically this is specified as an integer, although interpolation of floating-point values is supported by grid layout.</dd>
<dt>starSizing</dt><dd>starSizingA convention by which you can size rows or columns to take the remaining available space in a Grid. A star sizing always includes the asterisk character (\*), and optionally precedes the asterisk with an integer value that specifies a weighted factor versus other possible star sizings (for example, 3\*). For more information about star sizing, see Grid.</dd>
<dt>Auto</dt><dd>AutoThe column's width, described by the literal Auto. For more information about Auto sizing, see Grid or GridLength.</dd>
</dl>
## -property-value
The [GridLength](../windows.ui.xaml/gridlength.md) that represents the width of the column. The default value is a [GridLength](../windows.ui.xaml/gridlength.md) representing a "1\*" sizing.

## -remarks
The default value of Width is a [GridLength](../windows.ui.xaml/gridlength.md) representing a "1\*" sizing. This structure value has a **Value** data value of 1.0, and a **GridUnitType** data value of **Star**. With this default, each new [ColumnDefinition](columndefinition.md) you define for a [Grid](grid.md) will have "1\*" sizing, and each will be allotted an equal number of pixels for width of its content in layout handling. It's not uncommon to define [ColumnDefinition](columndefinition.md) as an object element in XAML without any attributes set and to just use this default behavior. The same is true for [RowDefinition](rowdefinition.md).

The value you set for Width can be constrained if you also set a value for [MinWidth](columndefinition_minwidth.md) or [MaxWidth](columndefinition_maxwidth.md). Each of these properties can take only pixel measurements, not **Star** sizing. If a [ColumnDefinition](columndefinition.md) uses **Star** or **Auto** sizing but also has [MinWidth](columndefinition_minwidth.md) or [MaxWidth](columndefinition_maxwidth.md) constraints, the [MinWidth](columndefinition_minwidth.md) or [MaxWidth](columndefinition_maxwidth.md) must be honored by the [Grid](grid.md) layout behavior, even if that means giving or taking layout space from other **Star** sizing columns defined in the [Grid](grid.md) that don't have constraints.

It's more common to use **Star** sizing than absolute pixel values for a [Grid](grid.md) definition in a UWP app using C++, C#, or Visual Basic. **Star** sizing supports the dynamic layout concept, which helps your app look great on screens with different sizes, pixel densities and orientations. For more info, see [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml).

## -examples

## -see-also
[Grid](grid.md), [Grid.ColumnDefinitions](grid_columndefinitions.md), [Grid.Column](/uwp/api/windows.ui.xaml.controls.grid.column), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
