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
Some of the reasons why you might get a [PointerCanceled](uielement_pointercanceled.md) occurrence are:
+ User actions that change the relationship of the display area, such as changing resolution or monitor settings
+ Input interactions such as a stylus touching the same surface as a previous touch action
+ The user logs off or similar interruptions that aren't app-specific
+ The number of simultaneous contacts exceeded the number supported by the device


> > [!IMPORTANT]
> [PointerCanceled](uielement_pointercanceled.md) might fire instead of [PointerReleased](uielement_pointerreleased.md). Don't rely on [PointerPressed](uielement_pointerpressed.md) and [PointerReleased](uielement_pointerreleased.md) events always occurring in pairs. To function properly, your app must listen for and handle all events that represent the possible conclusions to a **Press** action, and that includes [PointerCanceled](uielement_pointercanceled.md).

If [PointerCanceled](uielement_pointercanceled.md) fires, any pointer captures by that pointer are released. For more info on pointer capture, see [CapturePointer](uielement_capturepointer.md).

When handling a [PointerCanceled](uielement_pointercanceled.md) event, anticipate that some of the event data normally available for a pointer event won't be meaningful in the [PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md) object you get through your handler. For example, the [Position](../windows.ui.input/pointerpoint_position.md) of the pointer is invalid because the pointer no longer exists.

[PointerCanceled](uielement_pointercanceled.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

[PointerCanceled](uielement_pointercanceled.md) supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md). See [AddHandler](uielement_addhandler.md).

## -examples

## -see-also
[PointerReleased](uielement_pointerreleased.md), [PointerPressed](uielement_pointerpressed.md), [CapturePointer](uielement_capturepointer.md), [Handle pointer input](https://docs.microsoft.com/windows/uwp/design/input/handle-pointer-input), [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832), [XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=231524)