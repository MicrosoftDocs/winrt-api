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
The minimum height of the object, in pixels. The default is 0. This value can be any value equal to or greater than 0. However, [PositiveInfinity](https://msdn.microsoft.com/library/system.double.positiveinfinity.aspx) is not valid.

## -remarks
[MinHeight](frameworkelement_minheight.md) is one of three writable properties on [FrameworkElement](frameworkelement.md) that specify height information. The other two are [MaxHeight](frameworkelement_maxheight.md) and [MaxHeight](frameworkelement_maxheight.md). If there is a conflict between these values, the order of application for actual height determination is that first [MinHeight](frameworkelement_minheight.md) must be honored, then [MaxHeight](frameworkelement_maxheight.md), and finally, if it is within bounds, [Height](frameworkelement_height.md). All of these properties are recommendations to the layout behavior of the element's parent in the object tree. The height of the object after layout runs is available as the [ActualHeight](frameworkelement_actualheight.md) property value.



## -examples

## -see-also
[ActualHeight](frameworkelement_actualheight.md), [MaxHeight](frameworkelement_maxheight.md), [MaxHeight](frameworkelement_maxheight.md), [Define layouts with XAML](https://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079)
