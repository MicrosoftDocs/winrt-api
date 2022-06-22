---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Width
-api-type: winrt property
---

<!-- Property syntax
public double Width { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.Width

## -description
Gets or sets the width of a [FrameworkElement](frameworkelement.md).



## -xaml-syntax
```xaml
<frameworkElement Width="double"/>
-or-
<frameworkElement Width="Auto"/>
```


## -property-value
The width of the object, in pixels. The default is [NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true). Except for the special [NaN](/dotnet/api/system.double.nan?view=dotnet-uwp-10.0&preserve-view=true) value, this value must be equal to or greater than 0. 
<!--See Remarks for upper bound information.
      -->

## -remarks
Width is one of three writable properties on [FrameworkElement](frameworkelement.md) that specify width information. The other two are [MinWidth](frameworkelement_minwidth.md) and [MaxWidth](frameworkelement_maxwidth.md). If there is a conflict between these values, the order of application for actual width determination is that first [MinWidth](frameworkelement_minwidth.md) must be honored, then [MaxWidth](frameworkelement_maxwidth.md), and finally, if it is within bounds, Width.

Several of the [FrameworkElement](frameworkelement.md) derived types are also derived from [Shape](../windows.ui.xaml.shapes/shape.md). Not all of the [Shape](../windows.ui.xaml.shapes/shape.md) classes use [Height](frameworkelement_height.md) or Width to specify their appearance, and instead use specific properties that might define a set of points. In this case a [Height](frameworkelement_height.md) or Width is calculated, but is not typically set directly.

Custom classes might have similar considerations where the class might have properties that are more meaningful for specifying dimensions than are [Height](frameworkelement_height.md) or Width. [Height](frameworkelement_height.md) or Width are both still available as members and are settable. 
<!--In critical cases, it might be useful to shadow the Height and Width properties to prevent them from being set directly by consumers of the class. TODO can you shadow in WinRT?-->

The object where the [Height](frameworkelement_height.md) or Width properties are set is almost always a child object in another parent's child collection, and setting [Height](frameworkelement_height.md) or Width to a value is only a suggested value for the layout process. The layout system as well as the particular layout logic of the parent's class will use the value as a nonbinding input during the layout process, and might have to clip, resize the object, resize the container, or some combination of these behaviors that spans multiple participating objects in layout. Margin and padding also influences the available size. For more info, see [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding).

The return value of this property is always the same as any value that was set to it. In contrast, the value of the [ActualWidth](frameworkelement_actualwidth.md) property may vary. The variance can occur either statically, because the layout rejected the suggested size, or momentarily. The layout system itself works asynchronously relative to the property system's set of Width, and the layout system might not have processed that sizing property change yet.

Negative values for Width are not permitted. 
<!--Non-integral values for Height are technically permitted, but should generally be avoided and are normally rounded by the default layout rounding behavior. For more information, see Layout Rounding.
TODO investigate voldemort layout rounding-->
Also, do not set Width to a value that is significantly larger than the maximum size of any possible visual display.

### "Auto" and NaN

The default value of [Height](frameworkelement_height.md) and Width is "Auto", represented by NaN. In XAML markup, you can use the string "Auto" to set the value to NaN. 
<!--Setting Auto in XAML is a special behavior of the XAML parser, not a TypeConverter behavior.-->

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

The layout system interprets the "Auto" value to generally mean that the object should be sized to the available size in layout, instead of to a specific pixel value.

## -examples
This example shows a simple property set of a UI element that is created at run time and needs initialization of its content and basic display properties such as [Height](frameworkelement_height.md) and Width and [Background](../windows.ui.xaml.controls/control_background.md). ([Background](../windows.ui.xaml.controls/control_background.md) is actually a [Control](../windows.ui.xaml.controls/control.md) property, not defined by [FrameworkElement](frameworkelement.md).)



[!code-csharp[21](../windows.ui.xaml.data/code/ControlTasks/csharp/Page.xaml.cs#Snippet21)]

[!code-vb[21](../windows.ui.xaml.data/code/ControlTasks/vbnet/Page.xaml.vb#Snippet21)]

## -see-also
[Control](../windows.ui.xaml.controls/control.md), [Height](frameworkelement_height.md), [ActualWidth](frameworkelement_actualwidth.md), [MinWidth](frameworkelement_minwidth.md), [MaxWidth](frameworkelement_maxwidth.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding)
