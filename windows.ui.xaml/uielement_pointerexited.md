---
-api-id: E:Windows.UI.Xaml.UIElement.PointerExited
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.PointerEventHandler PointerExited
-->

# Windows.UI.Xaml.UIElement.PointerExited

## -description

Occurs when a pointer leaves the hit test area of this element.



## -xaml-syntax

```xaml
<uiElement PointerExited="eventhandler"/>
```

## -remarks

The PointerExited event fires in response to a pointer that was initially in the element's bounding area leaving that bounding area. Touch, mouse, and pen/stylus interactions are received, processed, and managed as pointer input in UWP app. Any of these devices and their interactions can produce a PointerExited event. For more info, see [Handle pointer input](/windows/uwp/design/input/handle-pointer-input) and the other remarks in this topic.

Use a handler based on [PointerEventHandler](../windows.ui.xaml.input/pointereventhandler.md) to handle this event.

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

PointerExited supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

Specific Windows Runtime controls may have class-based handling for the PointerExited input event. If so, the control probably has an override for the method [OnPointerExited](../windows.ui.xaml.controls/control_onpointerexited_795974211.md). Typically the event is not marked handled by the class handler, so the PointerExited event can still be handled by your user code for the control in your UI. For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

If another element has captured the pointer, PointerExited won't fire even if the captured pointer leaves an element's bounds. For more info on pointer capture, see [CapturePointer](uielement_capturepointer_916768934.md) or [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions).

### PointerExited for mouse and pen/stylus input

A mouse input device has an onscreen cursor that is visible whenever the mouse moves, even if no mouse button is pressed at the time. Similar behavior is available for pen device input, where the input devices can detect that the stylus is hovering just over the input device surface ([IsInRange](../windows.ui.xaml.input/pointer_isinrange.md)) but not touching it. Mouse and pen device input will thus fire PointerExited events in slightly different cases than touch events do. For more info, see [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions). A PointerExited event fires after the last [PointerMoved](uielement_pointerentered.md) event for the element fires.

### PointerExited for touch input

A touch point is only detectable if a finger is touching the surface. Whenever a touch action results in a [PointerReleased](uielement_pointerreleased.md) event, that event is immediately followed by a PointerExited event, with all the event data being the same information for the two events (same pointer ID, same position, and so on.) In other words the pointer is considered to enter the element at the moment and position that the element is touched by a touch point.

Alternatively, a touch point will generate PointerExited if that pointer remains in constant contact with the surface as it moves, was over the element initially, and then exits the hit testing bounds of an element. For these kinds of touch actions it's also possible that the action could be processed as a manipulation, or as a gesture, rather than a pointer event. For more info, see [Handle pointer input](/windows/uwp/design/input/handle-pointer-input).

### Routed event behavior for PointerExited

PointerExited is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview). You can define multiple PointerExited events for elements in a XAML UI, including for elements that are in a parent-child relationship. In a typical UI composition, the child elements are somewhere within a parent element's bounds, so the PointerExited event will first occur for the child when the pointer moves out of the child, and then for the parent when the pointer moves completely out of that parent. The PointerExited event doesn't typically bubble to the parent when the child element fires it, because it would be confusing for the input system to route the PointerExited event occurrence to the parent too. Typically you don't want PointerExited events to route anyways, you only want to process them from the sender. You can explicitly prevent event routing by setting [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md) to **true** in your handler.

In rare cases it's possible to see a PointerExited event bubble to the parent. For example, if you've used a [RenderTransform](uielement_rendertransform.md) to offset a child element outside the bounds of its parent, the event bubbles to the parent when the child element is exited, and gives the event info as reported by how the child element fired the event.

### PointerOver visual states for controls

Controls that have control templates can apply visual states that are active only when a pointer is over the bounds of the control. You don't always need to handle [PointerEntered](uielement_pointerentered.md) or PointerExited to get or change this behavior. You may need to re-template the control. If you are deriving from an existing control that already has the low-level input handling that invokes visual states, you should provide a visual state named "PointerOver" in the "CommonStates"  [VisualStateGroup](visualstategroup.md), and the built-in control logic will load that visual state whenever a pointer is over the control. A visual state for pointer-over is often present on controls that can be invoked or selected, like a [Button](../windows.ui.xaml.controls/button.md) or [ListViewItem](../windows.ui.xaml.controls/listviewitem.md). If you're deriving from a base class like [Control](../windows.ui.xaml.controls/control.md) that doesn't have built-in input event handling that invokes visual states, you may need to override [OnPointerEntered](../windows.ui.xaml.controls/control_onpointerentered_760744783.md) and [OnPointerExited](../windows.ui.xaml.controls/control_onpointerexited_795974211.md) yourself to get this behavior. Use [OnPointerExited](../windows.ui.xaml.controls/control_onpointerexited_795974211.md) to call [GoToState](visualstatemanager_gotostate_443481648.md) to load a state other than the "PointerOver" state, for example "Normal". For more info, see [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)).

### Windows 8 behavior

For Windows 8, generally the [PointerEntered](uielement_pointerentered.md) event won't fire if the onscreen cursor (or stylus or touchpoint) did not actually move. For example, [PointerEntered](uielement_pointerentered.md) doesn't fire if the mouse and its onscreen cursor remains stationary, and an object with a [PointerEntered](uielement_pointerentered.md) handler has its position translated or otherwise adjusted to move underneath the onscreen cursor. Or, [PointerEntered](uielement_pointerentered.md) doesn't fire if an element like a popup or flyout disappears and the pointer is now over a new element (but pointer hasn't moved yet). Related to this is the PointerExited behavior. For example, if a popup is dismissed programmatically, it won't fire PointerExited if the pointer didn't move as the cause of dismissing it. You would still get a [PointerEntered](uielement_pointerentered.md) event if the pointer moves while over the newly revealed element, but that's up to the user whether that will happen, and it happens at the time of movement, not the moment of dismissal. In short, trying to use the last element that fired [PointerEntered](uielement_pointerentered.md) for pointer state determination in the app UI isn't comprehensive in Windows 8, and there are many scenarios where [PointerEntered](uielement_pointerentered.md) and PointerExited won't pair up. This impacts the visual states for controls that use [PointerEntered](uielement_pointerentered.md) and PointerExited as triggers also.

Starting with Windows 8.1, PointerExited is fired for any case where the pointer had at one time fired a [PointerEntered](uielement_pointerentered.md) event, but some UI state change happens where the pointer is no longer within that element. This includes cases where the whole element disappears. And if the pointer is now over a different element because a previous element disappeared, that element fires [PointerEntered](uielement_pointerentered.md), even if the pointer never moves. Elements that set their [Visibility](uielement_visibility.md) to **Collapsed** programmatically is one way that elements might disappear from UI, and the Windows 8.1 behavior accounts for this and will fire PointerExited for the **Collapsed** element and [PointerEntered](uielement_pointerentered.md) for the newly revealed element.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in PointerExited and [PointerEntered](uielement_pointerentered.md) being fired in cases where they wouldn't have fired before.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also

[PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [PointerEntered](uielement_pointerentered.md), [PointerReleased](uielement_pointerreleased.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
