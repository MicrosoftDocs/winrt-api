---
-api-id: E:Windows.UI.Xaml.UIElement.PointerCaptureLost
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.PointerEventHandler PointerCaptureLost
-->

# Windows.UI.Xaml.UIElement.PointerCaptureLost

## -description

Occurs when pointer capture previously held by this element moves to another element or elsewhere.

## -xaml-syntax

```xaml
<uiElement PointerCaptureLost="eventhandler"/>
```

## -remarks

> > [!IMPORTANT]
> [PointerCaptureLost](uielement_pointercapturelost.md) might fire instead of [PointerReleased](uielement_pointerreleased.md). Don't rely on [PointerPressed](uielement_pointerpressed.md) and [PointerReleased](uielement_pointerreleased.md) events always occurring in pairs. To function properly, your app must listen for and handle all events that represent likely conclusions to the **Press** action, and that includes [PointerCaptureLost](uielement_pointercapturelost.md). A pointer can lose capture either because of user interactions or because you programmatically captured another pointer or released the current pointer capture deliberately.

There is no event that fires when a pointer is successfully captured. To capture a pointer, you call the [CapturePointer](uielement_capturepointer_916768934.md) method, and this is usually done within the context of an event handler for other pointer events. For more info on how to capture a pointer and why you might want to do so, see [CapturePointer](uielement_capturepointer_916768934.md) or [Mouse interactions](https://msdn.microsoft.com/library/c8a158ef-70a9-4ba2-a270-7d08125700ac).

[PointerCaptureLost](uielement_pointercapturelost.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](https://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

[PointerCaptureLost](uielement_pointercapturelost.md) supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked **Handled**. See [AddHandler](uielement_addhandler_2121467075.md).

## -examples

## -see-also

[PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [CapturePointer](uielement_capturepointer_916768934.md), [PointerCaptures](uielement_pointercaptures.md), [ReleasePointerCapture](uielement_releasepointercapture_962192786.md), [ReleasePointerCaptures](uielement_releasepointercaptures_190109337.md), [Handle pointer input](https://docs.microsoft.com/windows/uwp/design/input/handle-pointer-input), [Mouse interactions](https://msdn.microsoft.com/library/c8a158ef-70a9-4ba2-a270-7d08125700ac), [XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=231524)
