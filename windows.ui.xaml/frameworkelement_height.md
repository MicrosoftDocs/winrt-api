---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Height
-api-type: winrt property
---

<!-- Property syntax
public double Height { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.Height

## -description
Gets or sets the suggested height of a [FrameworkElement](frameworkelement.md).

## -xaml-syntax
```xaml
<frameworkElement Height="double"/>
-or-
<frameworkElement Height="Auto"/>
 
```


## -property-value
The height, in pixels, of the object. The default is [NaN](https://msdn.microsoft.com/library/system.double.nan.aspx). Except for the special [NaN](https://msdn.microsoft.com/library/system.double.nan.aspx) value, this value must be equal to or greater than 0.

## -remarks
[Height](frameworkelement_height.md) is one of three writable properties on [FrameworkElement](frameworkelement.md) that specify height information. The other two are [MinHeight](frameworkelement_minheight.md) and [MaxHeight](frameworkelement_maxheight.md). If there is a conflict between these values, the order of application for actual height determination is that first [MinHeight](frameworkelement_minheight.md) must be honored, then [MaxHeight](frameworkelement_maxheight.md), and finally, if it is within bounds, [Height](frameworkelement_height.md).

Several of the [FrameworkElement](frameworkelement.md) derived types are also derived from [Shape](../windows.ui.xaml.shapes/shape.md). Not all of the [Shape](../windows.ui.xaml.shapes/shape.md) classes use [Height](frameworkelement_height.md) or [Width](frameworkelement_width.md) to specify their appearance, and instead use specific properties that might define a set of points. In this case a [Height](frameworkelement_height.md) or [Width](frameworkelement_width.md) is calculated, but is not typically set directly.

Custom classes might have similar considerations where the class might have properties that are more meaningful for specifying dimensions than are [Height](frameworkelement_height.md) or [Width](frameworkelement_width.md). [Height](frameworkelement_height.md) or [Width](frameworkelement_width.md) are both still available as members and are settable. 
<!--In critical cases, it might be useful to shadow the Height and Width properties to prevent them from being set directly by consumers of the class. TODO can you shadow in WinRT?-->

The object where the [Height](frameworkelement_height.md) or [Width](frameworkelement_width.md) properties are set is almost always a child object in another parent's child collection, and setting [Height](frameworkelement_height.md) or [Width](frameworkelement_width.md) to a value is only a suggested value for the layout process. The layout system as well as the particular layout logic of the parent's class will use the value as a nonbinding input during the layout process, and might have to clip, resize the object, resize the container, or some combination of these behaviors that spans multiple participating objects in layout. Margin and padding also influences the available size. For more info, see [Alignment, margin, and padding](https://msdn.microsoft.com/library/9412abd4-3674-4865-b07d-64c7c26e4842).

The return value of this property is always the same as any value that was set to it. In contrast, the value of the [ActualHeight](frameworkelement_actualheight.md) property may vary. The variance can occur either statically, because the layout rejected the suggested size, or momentarily. The layout system itself works asynchronously relative to the property system's set of [Height](frameworkelement_height.md), and the layout system might not have processed that sizing property change yet.

Negative values for [Height](frameworkelement_height.md) are not permitted. 
<!--Non-integral values for Height are technically permitted, but should generally be avoided and are normally rounded by the default layout rounding behavior. For more information, see Layout Rounding.
TODO investigate voldemort layout rounding-->
Also, do not set [Height](frameworkelement_height.md)to a value that is significantly larger than the maximum size of any possible visual display.

### "Auto" layout and Double.NaN

The default value of [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md) is not 0, it is [Double.NaN](https://msdn.microsoft.com/library/system.double.nan.aspx). [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md) support the ability to be an unset "Auto" value. Because [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md) are **Double** values, [Double.NaN](https://msdn.microsoft.com/library/system.double.nan.aspx) is used as a special value to represent this "Auto" behavior. The layout system interprets the "Auto" value to generally mean that the object should be sized to the available size in layout, instead of to a specific pixel value. If you want the "Auto" behavior for an object when it is used in layout, leave [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md) unset at their [Double.NaN](https://msdn.microsoft.com/library/system.double.nan.aspx) default value. If you have previously set values and want to reenable the "Auto" behavior with run-time code, set to [Double.NaN](https://msdn.microsoft.com/library/system.double.nan.aspx). In XAML such as templates, you can set attribute values using the string "Auto". 
<!--Setting Auto in XAML is a special behavior of the XAML parser, not a TypeConverter behavior.-->


> [!NOTE]
> Visual C++ component extensions (C++/CX) doesn't have a constant for **NaN**, it uses a value, which appears as "-1.#IND" followed by zeros.

## -examples
This example shows a simple property set of a UI element that is created at run time and needs initialization of its content and basic display properties such as [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md) and [Background](../windows.ui.xaml.controls/control_background.md). ([Background](../windows.ui.xaml.controls/control_background.md) is actually a [Control](../windows.ui.xaml.controls/control.md) property, not defined by [FrameworkElement](frameworkelement.md).)



[!code-csharp[21](../windows.ui.xaml.data/code/ControlTasks/csharp/Page.xaml.cs#Snippet21)]

[!code-vb[21](../windows.ui.xaml.data/code/ControlTasks/vbnet/Page.xaml.vb#Snippet21)]

## -see-also
[Width](frameworkelement_width.md), [ActualHeight](frameworkelement_actualheight.md), [MinHeight](frameworkelement_minheight.md), [MaxHeight](frameworkelement_maxheight.md), [Define layouts with XAML](https://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079), [Alignment, margin, and padding](https://msdn.microsoft.com/library/9412abd4-3674-4865-b07d-64c7c26e4842)
abd4-3674-4865-b07d-64c7c26e4842)
