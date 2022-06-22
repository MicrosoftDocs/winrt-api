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
> PointerCaptureLost might fire instead of [PointerReleased](uielement_pointerreleased.md). Don't rely on [PointerPressed](uielement_pointerpressed.md) and [PointerReleased](uielement_pointerreleased.md) events always occurring in pairs. To function properly, your app must listen for and handle all events that represent likely conclusions to the **Press** action, and that includes PointerCaptureLost. A pointer can lose capture either because of user interactions or because you programmatically captured another pointer or released the current pointer capture deliberately.

There is no event that fires when a pointer is successfully captured. To capture a pointer, you call the [CapturePointer](uielement_capturepointer_916768934.md) method, and this is usually done within the context of an event handler for other pointer events. For more info on how to capture a pointer and why you might want to do so, see [CapturePointer](uielement_capturepointer_916768934.md) or [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions).

PointerCaptureLost is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

PointerCaptureLost supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked **Handled**. See [AddHandler](uielement_addhandler_2121467075.md).

## -examples

## -see-also

[PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [CapturePointer](uielement_capturepointer_916768934.md), [PointerCaptures](uielement_pointercaptures.md), [ReleasePointerCapture](uielement_releasepointercapture_962192786.md), [ReleasePointerCaptures](uielement_releasepointercaptures_190109337.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
