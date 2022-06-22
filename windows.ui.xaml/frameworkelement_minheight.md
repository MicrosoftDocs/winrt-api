---
-api-id: P:Windows.UI.Xaml.FrameworkElement.MinHeight
-api-type: winrt property
---

<!-- Property syntax
public double MinHeight { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.MinHeight

## -description
Gets or sets the minimum height constraint of a [FrameworkElement](frameworkelement.md).



## -xaml-syntax
```xaml
<frameworkElement MinHeight="double"/>
```


## -property-value
The minimum height of the object, in pixels. The default is 0. This value can be any value equal to or greater than 0. However, [PositiveInfinity](/dotnet/api/system.double.positiveinfinity?view=dotnet-uwp-10.0&preserve-view=true) is not valid.

## -remarks
MinHeight is one of three writable properties on [FrameworkElement](frameworkelement.md) that specify height information. The other two are [Height](frameworkelement_height.md) and [MaxHeight](frameworkelement_maxheight.md). If there is a conflict between these values, the order of application for actual height determination is that first MinHeight must be honored, then [MaxHeight](frameworkelement_maxheight.md), and finally, if it is within bounds, [Height](frameworkelement_height.md). All of these properties are recommendations to the layout behavior of the element's parent in the object tree. The height of the object after layout runs is available as the [ActualHeight](frameworkelement_actualheight.md) property value.



## -examples

## -see-also
[ActualHeight](frameworkelement_actualheight.md), [Height](frameworkelement_height.md), [MaxHeight](frameworkelement_maxheight.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
