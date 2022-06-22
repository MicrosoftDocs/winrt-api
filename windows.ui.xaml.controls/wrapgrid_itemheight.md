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



## -xaml-syntax
```xaml
<WrapGrid ItemHeight="double" />
```


## -property-value
The height of the layout area for each item that is contained in a [WrapGrid](wrapgrid.md). The default is NaN. See Remarks below.

## -remarks

<!-- "Auto" is not supported in XAML markup for this property -->
If ItemHeight is NaN, then the WrapGrid uses the height of the first cell.

> [!NOTE]
> In C#, you can obtain NaN from [Double.NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true).
>
> In C++, you can obtain NaN by using the [`NAN` macro](/cpp/standard-library/cmath) or [`std::numeric_limits<double>::quiet_NaN`](/cpp/standard-library/numeric-limits-class#quiet_nan).
>
> Do not use the `==` operator to test for NaN.
>
> In C#, use [Double.IsNaN()](/dotnet/api/system.double.isnan?view=dotnet-uwp-10.0&preserve-view=true) to test for NaN.
>
> In C++, use [isnan()](/cpp/c-runtime-library/reference/isnan-isnan-isnanf) to test for NaN.

## -examples

## -see-also
[ItemWidth](wrapgrid_itemwidth.md)
