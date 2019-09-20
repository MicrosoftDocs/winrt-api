---
-api-id: M:Windows.UI.Xaml.UIElement.TransformToVisual(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Media.GeneralTransform TransformToVisual(Windows.UI.Xaml.UIElement visual)
-->

# Windows.UI.Xaml.UIElement.TransformToVisual

## -description
Returns a transform object that can be used to transform coordinates from the [UIElement](uielement.md) to the specified object.

## -parameters
### -param visual
The object to compare to the current object for purposes of obtaining the transform.
If this parameter is null, then the root of the XAML tree is used. 

## -returns
The transform information as an object. Call methods on this object to get a practical transform.

## -remarks
Call TransformToVisual in order to get a coordinate offset between two elements in a UI. The first element being considered is the [UIElement](uielement.md) where you call TransformToVisual, the second element is the [UIElement](uielement.md) you pass as the *visual* parameter. For example, you can use the transform to determine how the bounds of an element are positioned in a coordinate system that is relative to a layout parent element, rather than the app's window.

TransformToVisual gives coordinate results after all considerations that affect rendering and positioning such as [RenderTransform](uielement_rendertransform.md) have been applied. This is useful if you're processing point values that were obtained during an animation of [RenderTransform](uielement_rendertransform.md) or other position changes.

The most common scenario for TransformToVisual is if you want to use a local coordinate system relative to the [UIElement](uielement.md) you call it on, and you aren't handling a real-time input event that has event data methods for converting a [Point](../windows.foundation/point.md) value into the object's frame of reference. After you call TransformToVisual, you can then call [TransformPoint](../windows.ui.xaml.media/generaltransform_transformpoint_1768161830.md) on the returned [GeneralTransform](../windows.ui.xaml.media/generaltransform.md).

> [!NOTE]
> The [GeneralTransform](../windows.ui.xaml.media/generaltransform.md) object returned by this method can be cast to a derived type, [Transform](../windows.ui.xaml.media/transform.md), but all the methods you need are defined by [GeneralTransform](../windows.ui.xaml.media/generaltransform.md). You can't cast to [TranslateTransform](../windows.ui.xaml.media/translatetransform.md) even though you might expect that the transform result would be a translation.

## -examples
This example shows a scenario for calling TransformToVisual in order to interpret the coordinates from a [PointerPoint](../windows.ui.input/pointerpoint.md) in the coordinate reference frame of an element that's not the event sender. Here, the `queryPointer` method first accesses coordinates that do relate to the sender (this is the [GetCurrentPoint](../windows.ui.input/pointerpoint_getcurrentpoint_131721878.md) call in the first line of the method) but then later uses TransformToVisual to convert point coordinates into the reference frame for the `page` layout container that's actually several layers of containment up in the XAML. To see more context for this code (including seeing how `queryPointer` displays results in UI and when it's called), see the complete code example that is shown in the topic [Handle pointer input](https://docs.microsoft.com/windows/uwp/design/input/handle-pointer-input).



[!code-xaml[UI](../windows.ui.input.inking/code/PointerInput/csharp/MainPage.xaml#SnippetUI)]

[!code-xaml[UI](../windows.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml#SnippetUI)]

[!code-csharp[QueryPointer](../windows.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetQueryPointer)]

[!code-csharp[QueryPointer](../windows.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml.cs#SnippetQueryPointer)]

## -see-also
[GeneralTransform](../windows.ui.xaml.media/generaltransform.md), [Define layouts with XAML](https://docs.microsoft.com/windows/uwp/layout/layouts-with-xaml), [XAML two-dimensional transforms sample](https://go.microsoft.com/fwlink/p/?linkid=226868)
