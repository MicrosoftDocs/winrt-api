---
-api-id: E:Windows.UI.Xaml.UIElement.PointerPressed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.PointerEventHandler PointerPressed
-->

# Windows.UI.Xaml.UIElement.PointerPressed

## -description

Occurs when the pointer device initiates a **Press** action within this element.



## -xaml-syntax

```xaml
<uiElement PointerPressed="eventhandler"/>
```

## -remarks

Touch, mouse, and pen/stylus interactions are received, processed, and managed as pointer input in UWP app. Any of these interactions can produce a PointerPressed event. For more info, see [Handle pointer input](/windows/uwp/design/input/handle-pointer-input). Pointer events are intended for scenarios where you're interested in multiple pointers and their relationships, or when you are examining specifics of each pointer such as exact coordinate position. Otherwise, you might consider handling gesture events such as [Tapped](uielement_tapped.md).

Use a handler based on [PointerEventHandler](../windows.ui.xaml.input/pointereventhandler.md) to handle this event.

Mouse input is associated with a single pointer assigned when mouse input is first detected. Clicking a mouse button (left, wheel, or right) creates a secondary association between the pointer and that button through the PointerPressed event. The [PointerReleased](uielement_pointerreleased.md) event is fired only when that same mouse button is released (no other button can be associated with the pointer until this event is complete). Because of this exclusive association, other mouse button clicks are routed through the [PointerMoved](uielement_pointermoved.md) event. You can test the mouse button state when handling this event, as shown in the following example.

[!code-csharp[PointerMoved](../windows.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetPointerMoved)]

[!code-csharp[PointerMoved](../windows.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml.cs#SnippetPointerMoved)]

Pointer events from a mouse input device generally have the same [PointerId](../windows.ui.input/pointerpoint_pointerid.md) in the event details for the lifetime of the app.

PointerPressed is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

PointerPressed supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

Specific Windows Runtime controls may have class-based handling for the PointerPressed input event. If so, the control probably has an override for the method [OnPointerPressed](../windows.ui.xaml.controls/control_onpointerpressed_1718956371.md). Typically the event is marked handled by the class handler, and the PointerPressed event is not raised for handling by any user code handlers on that control. For example, [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) has class handling that handles PointerPressed and instead fires [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md). For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Controls may also have a [PointerDownThemeAnimation](../windows.ui.xaml.media.animation/pointerdownthemeanimation.md) personality animation that run independently of the event.

### Pointer capture

PointerPressed is sometimes used as the initiating event when capturing the pointer, so that further pointer-related events are all captured by a particular element so long as the pointer remains down. To capture a pointer, you call the [CapturePointer](uielement_capturepointer_916768934.md) method on a specific UI element that should maintain the capture. This is usually done within a PointerPressed event handler, and you call [CapturePointer](uielement_capturepointer_916768934.md) on the event's *sender*. For more info on how to capture a pointer and why you might want to do so, see [CapturePointer](uielement_capturepointer_916768934.md).

### PointerPressed and gesture events, or manipulation events

The user action that fires a PointerPressed event initially can eventually result in the [Holding](uielement_holding.md) event representing a **Hold** gesture, unless the input device is a mouse. If the element where PointerPressed occurs has a non-default [ManipulationMode](uielement_manipulationmode.md) value, then the action might also result in various manipulation events like [ManipulationStarted](uielement_manipulationstarted.md). For more info, see "Using manipulation events" section in [Handle pointer input](/windows/uwp/design/input/handle-pointer-input).

When PointerPressed fires, gesture events such as [Tapped](uielement_tapped.md) won't fire yet because the gesture events other than [Holding](uielement_holding.md) are waiting for the pointer to be released before firing an event.

As a general design rule for your app's user interactions, you should examine whether there are control-specific events you can handle for an interaction, or appropriate gesture events. For example, if your control is a [Button](../windows.ui.xaml.controls/button.md), that control has a [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event that's specifically intended for when the user invokes the button's action. Or if your element isn't a button but you're handling and event for an element's primary action, you would handle [Tapped](uielement_tapped.md).

Gesture events can be specifically disabled on individual elements by setting properties such as [IsTapEnabled](uielement_istapenabled.md). You might disable the gesture events if you are processing manipulations, but you typically don't need to disable gesture events if you're handling pointer events. Pointer events can't be specifically disabled, but you can choose to not handle them.

### PointerPressed and PointerReleased

Other events instead of [PointerReleased](uielement_pointerreleased.md) may fire at the end of the action— for example, [PointerCanceled](uielement_pointercanceled.md) or [PointerCaptureLost](uielement_pointercapturelost.md). Don't rely on PointerPressed and [PointerReleased](uielement_pointerreleased.md) events always occurring in pairs. To function properly, your app must listen for and handle all events that represent likely conclusions to the **Press** action. Some of the reasons why you might not get a [PointerReleased](uielement_pointerreleased.md) occurrence are:

+ Differences in how specific hardware handles touch actions and **Press** actions
+ A programmatic pointer capture from a different pointer
+ User actions that change the relationship of the display area, such as changing resolution or monitor settings
+ Input interactions such as a stylus touching the same surface as a previous touch action

## -examples

## -see-also

[PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [Tapped](uielement_tapped.md), [PointerReleased](uielement_pointerreleased.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
