---
-api-id: E:Windows.UI.Xaml.UIElement.PointerCanceled
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.PointerEventHandler PointerCanceled
-->

# Windows.UI.Xaml.UIElement.PointerCanceled

## -description

Occurs when a pointer that made contact abnormally loses contact.



## -xaml-syntax

```xaml
<uiElement PointerCanceled="eventhandler"/>
```

## -remarks

Some of the reasons why you might get a PointerCanceled occurrence are:

+ User actions that change the relationship of the display area, such as changing resolution or monitor settings
+ Input interactions such as a stylus touching the same surface as a previous touch action
+ The user logs off or similar interruptions that aren't app-specific
+ The number of simultaneous contacts exceeded the number supported by the device

> > [!IMPORTANT]
> PointerCanceled might fire instead of [PointerReleased](uielement_pointerreleased.md). Don't rely on [PointerPressed](uielement_pointerpressed.md) and [PointerReleased](uielement_pointerreleased.md) events always occurring in pairs. To function properly, your app must listen for and handle all events that represent the possible conclusions to a **Press** action, and that includes PointerCanceled.

If PointerCanceled fires, any pointer captures by that pointer are released. For more info on pointer capture, see [CapturePointer](uielement_capturepointer_916768934.md).

When handling a PointerCanceled event, anticipate that some of the event data normally available for a pointer event won't be meaningful in the [PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md) object you get through your handler. For example, the [Position](../windows.ui.input/pointerpoint_position.md) of the pointer is invalid because the pointer no longer exists.

PointerCanceled is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

PointerCanceled supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

## -examples

## -see-also

[PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [PointerReleased](uielement_pointerreleased.md), [PointerPressed](uielement_pointerpressed.md), [CapturePointer](uielement_capturepointer_916768934.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
