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

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.PlaneProjection](/windows/winui/api/microsoft.ui.xaml.media.planeprojection) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<PlaneProjection .../>
```


## -remarks

## -examples
To apply a perspective transform to a [UIElement](../windows.ui.xaml/uielement.md), set the [UIElement](../windows.ui.xaml/uielement.md) object's [Projection](../windows.ui.xaml/uielement_projection.md) property to a PlaneProjection. The PlaneProjection defines how the transform is rendered in space. This example shows a simple case.



[!code-xaml[BasicPerspectiveTransforms](../windows.ui.xaml/code/BasicPerspectiveTransforms/csharp/MainPage.xaml#SnippetBasicPerspectiveTransforms)]

## -see-also
[3-D effects for ](/previous-versions/windows/apps/hh700359(v=win.10)), [Projection](projection.md)
