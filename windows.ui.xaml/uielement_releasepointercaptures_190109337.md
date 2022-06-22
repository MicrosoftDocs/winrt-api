---
-api-id: M:Windows.UI.Xaml.UIElement.ReleasePointerCaptures
-api-type: winrt method
---

<!-- Method syntax
public void ReleasePointerCaptures()
-->

# Windows.UI.Xaml.UIElement.ReleasePointerCaptures

## -description

Releases all pointer captures held by this element.



## -remarks

Because there are input scenarios such as manipulations that involve more than one pointer point, the Windows Runtime enables capturing more than one pointer at a time. Calling [ReleasePointerCapture](uielement_releasepointercapture_962192786.md) removes a specific [Pointer](../windows.ui.xaml.input/pointer.md) from the collection as identified by its ID, whereas ReleasePointerCaptures clears the entire collection.

User action that invalidates pointer capture such as releasing from a pointer point also changes capture state. For more info, see [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions) and [Handle pointer input](/windows/uwp/design/input/handle-pointer-input).

The [PointerCaptures](uielement_pointercaptures.md) property exposes a view of which pointer points are currently captured by the [UIElement](uielement.md).

## -examples

## -see-also

[ReleasePointerCapture](uielement_releasepointercapture_962192786.md), [CapturePointer](uielement_capturepointer_916768934.md), [PointerReleased](uielement_pointerreleased.md), [PointerCaptureLost](uielement_pointercapturelost.md), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [Input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
