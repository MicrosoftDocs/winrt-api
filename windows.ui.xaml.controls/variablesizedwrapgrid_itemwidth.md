---
-api-id: P:Windows.UI.Xaml.Controls.VariableSizedWrapGrid.ItemWidth
-api-type: winrt property
---

<!-- Property syntax
public double ItemWidth { get;  set; }
-->

# Windows.UI.Xaml.Controls.VariableSizedWrapGrid.ItemWidth

## -description
Gets or sets the width of the layout area for each item that is contained in a [VariableSizedWrapGrid](variablesizedwrapgrid.md).



## -xaml-syntax
```xaml
<VariableSizedWrapGrid ItemWidth="double" />
-or-
<VariableSizedWrapGrid ItemWidth="Auto" />
```


## -property-value
The width of the layout area for each item that is contained in a [VariableSizedWrapGrid](variablesizedwrapgrid.md). The default is NaN. See Remarks below.

## -remarks

<!-- "Auto" is not supported in XAML markup for this property -->
If ItemWidth is NaN, then the VariableSizedWrapGrid uses the width of the first cell.

> [!NOTE]
> In C#, you can obtain NaN from [Double.NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true).
>
> In C++, you can obtain NaN by using the [`NAN` macro](/cpp/standard-library/cmath) or [`std::numeric_limits<double>::quiet_NaN()`](/cpp/standard-library/numeric-limits-class#quiet_nan).
>
> Do not use the `==` operator to test for NaN.
>
> In C#, use [Double.IsNaN()](/dotnet/api/system.double.isnan?view=dotnet-uwp-10.0&preserve-view=true) to test for NaN.
>
> In C++, use [isnan()](/cpp/c-runtime-library/reference/isnan-isnan-isnanf) to test for NaN.

## -examples

## -see-also
[ItemHeight](variablesizedwrapgrid_itemheight.md)
