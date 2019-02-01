---
-api-id: T:Windows.UI.Xaml.Media.PlaneProjection
-api-type: winrt class
---

<!-- Class syntax.
public class PlaneProjection : Windows.UI.Xaml.Media.Projection, Windows.UI.Xaml.Media.IPlaneProjection
-->

# Windows.UI.Xaml.Media.PlaneProjection

## -description
Represents a perspective transform (a 3-D-like effect) on an object.

## -xaml-syntax
```xaml
<PlaneProjection .../>
```


## -remarks

## -examples
To apply a perspective transform to a [UIElement](../windows.ui.xaml/uielement.md), set the [UIElement](../windows.ui.xaml/uielement.md) object's [Projection](../windows.ui.xaml/uielement_projection.md) property to a [PlaneProjection](planeprojection.md). The [PlaneProjection](planeprojection.md) defines how the transform is rendered in space. This example shows a simple case.



[!code-xml[BasicPerspectiveTransforms](../windows.ui.xaml/code/BasicPerspectiveTransforms/csharp/MainPage.xaml#SnippetBasicPerspectiveTransforms)]

## -see-also
[3-D effects for ](https://msdn.microsoft.com/library/abcbbdb6-02a5-4e4e-a8dc-ceacedb91913), [Projection](projection.md)
