---
-api-id: E:Windows.UI.Xaml.UIElement.PointerReleased
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.PointerEventHandler PointerReleased
-->

# Windows.UI.Xaml.UIElement.PointerReleased

## -description

Occurs when the pointer device that previously initiated a **Press** action is released, while within this element. Note that the end of a **Press** action is not guaranteed to fire a PointerReleased event; other events may fire instead. For more info, see Remarks.



## -xaml-syntax

```xaml
<uiElement PointerReleased="eventhandler"/>
```

## -remarks

Touch, mouse, and pen/stylus interactions are received, processed, and managed as pointer input in UWP app. Any of these interactions can produce a PointerReleased event. For more info, see [Handle pointer input](/windows/uwp/design/input/handle-pointer-input).

Other events instead of PointerReleased may fire at the end of the action— for example, [PointerCanceled](uielement_pointercanceled.md) or [PointerCaptureLost](uielement_pointercapturelost.md). Don't rely on [PointerPressed](uielement_pointerpressed.md) and PointerReleased events always occurring in pairs. To function properly, your app must listen for and handle all events that represent likely conclusions to the **Press** action. Some of the reasons why you might not get a PointerReleased occurrence are:

+ Differences in how specific hardware handles touch actions and **Press** actions
+ A programmatic pointer capture from a different pointer
+ User actions that change the relationship of the display area, such as changing resolution or monitor settings
+ Input interactions such as a stylus touching the same surface as a previous touch action

The user action that fires a PointerReleased event initially can result in the [Tapped](uielement_tapped.md) event, or can also result in [RightTapped](uielement_righttapped.md) under conditions that vary per device. For more info, see [Tapped](uielement_tapped.md) and [RightTapped](uielement_righttapped.md).

Mouse input is associated with a single pointer assigned when mouse input is first detected. Clicking a mouse button (left, wheel, or right) creates a secondary association between the pointer and that button through the [PointerPressed](uielement_pointerpressed.md) event. The PointerReleased event is fired only when that same mouse button is released (no other button can be associated with the pointer until this event is complete). Because of this exclusive association, other mouse button clicks are routed through the [PointerMoved](uielement_pointermoved.md) event. You can test the mouse button state when handling this event, as shown in the following example.

[!code-csharp[PointerMoved](../windows.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetPointerMoved)]

[!code-csharp[PointerMoved](../windows.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml.cs#SnippetPointerMoved)]

PointerReleased is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

PointerReleased supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

Specific Windows Runtime controls may have class-based handling for the PointerReleased input event. If so, the control probably has an override for the method [OnPointerReleased](../windows.ui.xaml.controls/control_onpointerreleased_2120631493.md). Typically the event is marked handled by the class handler, and the PointerReleased event is not raised for handling by any user code handlers on that control. For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Controls may also have a [PointerUpThemeAnimation](../windows.ui.xaml.media.animation/pointerupthemeanimation.md) personality animation that run independently of the event.

## -examples

## -see-also

[PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [Tapped](uielement_tapped.md), [PointerPressed](uielement_pointerpressed.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
