---
-api-id: P:Windows.UI.Xaml.FrameworkElement.MaxHeight
-api-type: winrt property
---

<!-- Property syntax
public double MaxHeight { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.MaxHeight

## -description
Gets or sets the maximum height constraint of a [FrameworkElement](frameworkelement.md).

## -xaml-syntax
```xaml
<frameworkElement MaxHeight="double"/>
 
```


## -property-value
The maximum height of the object, in pixels. The default value is [PositiveInfinity](https://msdn.microsoft.com/library/system.double.positiveinfinity.aspx). This value can be any value equal to or greater than 0. [PositiveInfinity](https://msdn.microsoft.com/library/system.double.positiveinfinity.aspx) is also valid.

## -remarks
[MaxHeight](frameworkelement_maxheight.md) is one of three writable properties on [FrameworkElement](frameworkelement.md) that specify height information. The other two are [Height](frameworkelement_height.md) and [Height](frameworkelement_height.md). If there is a conflict between these values, the order of application for actual height determination is that first [MinHeight](frameworkelement_minheight.md) must be honored, then [MaxHeight](frameworkelement_maxheight.md), and finally, if it is within bounds, [Height](frameworkelement_height.md). All of these properties are recommendations to the layout behavior of the element's parent in the object tree. The height of the object after layout runs is available as the [ActualHeight](frameworkelement_actualheight.md) property value.

The final [ActualHeight](frameworkelement_actualheight.md) of an element might exceed [MaxHeight](frameworkelement_maxheight.md). For example, if [UseLayoutRounding](uielement_uselayoutrounding.md) is set to **true** and your app is running on a display with a Resolution Scale greater than 100%, then the [ActualHeight](frameworkelement_actualheight.md) may be rounded up to help ensure your UI doesn't look blurry when scaled.

## -examples
This XAML example shows a technique of specifying a [MaxHeight](frameworkelement_maxheight.md) for a [ViewBox](../windows.ui.xaml.controls/viewbox.md). [ViewBox](../windows.ui.xaml.controls/viewbox.md) is a decorator that can apply layout information to a single child and divide layout areas for the next parent element (in this case a [StackPanel](../windows.ui.xaml.controls/stackpanel.md)).



[!code-xml[ViewBoxXAML](../windows.ui.xaml/code/ViewBoxSnippet/csharp/MainPage.xaml#SnippetViewBoxXAML)]

## -see-also
[ActualHeight](frameworkelement_actualheight.md), [Height](frameworkelement_height.md), [Height](frameworkelement_height.md), [Define layouts with XAML](https://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079)
