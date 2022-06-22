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
The maximum height of the object, in pixels. The default value is [PositiveInfinity](/dotnet/api/system.double.positiveinfinity?view=dotnet-uwp-10.0&preserve-view=true). This value can be any value equal to or greater than 0. [PositiveInfinity](/dotnet/api/system.double.positiveinfinity?view=dotnet-uwp-10.0&preserve-view=true) is also valid.

## -remarks
MaxHeight is one of three writable properties on [FrameworkElement](frameworkelement.md) that specify height information. The other two are [Height](frameworkelement_height.md) and [MinHeight](frameworkelement_minheight.md). If there is a conflict between these values, the order of application for actual height determination is that first [MinHeight](frameworkelement_minheight.md) must be honored, then MaxHeight, and finally, if it is within bounds, [Height](frameworkelement_height.md). All of these properties are recommendations to the layout behavior of the element's parent in the object tree. The height of the object after layout runs is available as the [ActualHeight](frameworkelement_actualheight.md) property value.

The final [ActualHeight](frameworkelement_actualheight.md) of an element might exceed MaxHeight. For example, if [UseLayoutRounding](uielement_uselayoutrounding.md) is set to **true** and your app is running on a display with a Resolution Scale greater than 100%, then the [ActualHeight](frameworkelement_actualheight.md) may be rounded up to help ensure your UI doesn't look blurry when scaled.

## -examples
This XAML example shows a technique of specifying a MaxHeight for a [ViewBox](../windows.ui.xaml.controls/viewbox.md). [ViewBox](../windows.ui.xaml.controls/viewbox.md) is a decorator that can apply layout information to a single child and divide layout areas for the next parent element (in this case a [StackPanel](../windows.ui.xaml.controls/stackpanel.md)).



[!code-xaml[ViewBoxXAML](../windows.ui.xaml/code/ViewBoxSnippet/csharp/MainPage.xaml#SnippetViewBoxXAML)]

## -see-also
[ActualHeight](frameworkelement_actualheight.md), [Height](frameworkelement_height.md), [MinHeight](frameworkelement_minheight.md), [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
