---
-api-id: P:Windows.UI.Xaml.Controls.TextBlock.BaselineOffset
-api-type: winrt property
---

<!-- Property syntax
public double BaselineOffset { get; }
-->

# Windows.UI.Xaml.Controls.TextBlock.BaselineOffset

## -description
Returns a value by which each line of text is offset from a baseline.



## -property-value
The amount by which each line of text is offset from the baseline, in device independent pixels. The default is NaN. See Remarks below.

## -remarks

If the BaselineOffset is NaN, then an optimal baseline offset is automatically calculated from the current font characteristics.

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
