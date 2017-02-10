---
-api-id: E:Windows.UI.Xaml.UIElement.PointerEntered
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.PointerEventHandler PointerEntered
-->

# Windows.UI.Xaml.UIElement.PointerEntered

## -description
Occurs when a pointer enters the hit test area of this element.

## -xaml-syntax
```xaml
<uiElement PointerEntered="eventhandler"/>
```


## -remarks
The [PointerEntered](uielement_pointerentered.md) event fires in response to a pointer moving into the element's bounding area. Touch, mouse, and pen/stylus interactions are received, processed, and managed as pointer input in Windows Store app. Any of these devices and their interactions can produce a [PointerEntered](uielement_pointerentered.md) event. For more info, see [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82) and also the other remarks in this topic.

Use a handler based on [PointerEventHandler](../windows.ui.xaml.input/pointereventhandler.md) to handle this event.

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

[PointerEntered](uielement_pointerentered.md) supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md). See [AddHandler](uielement_addhandler.md).

Specific Windows Runtime controls may have class-based handling for the [PointerEntered](uielement_pointerentered.md) input event. If so, the control probably has an override for the method [OnPointerEntered](../windows.ui.xaml.controls/control_onpointerentered.md). Typically the event is not marked handled by the class handler, so the [PointerEntered](uielement_pointerentered.md) event can still be handled by your user code for the control in your UI. For more info on how class-based handling for events works, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

### PointerEntered for mouse and pen/stylus input

A mouse input device has an onscreen cursor that is visible whenever the mouse moves, even if no mouse button is pressed at the time. A [PointerEntered](uielement_pointerentered.md) event will precede the first [PointerMoved](uielement_pointerentered.md) event fired by the element. Similar behavior is available for pen device input, where the input devices can detect that the stylus is hovering just over the input device surface ([IsInRange](../windows.ui.xaml.input/pointer_isinrange.md)) but not touching it. Mouse and pen device input will thus fire [PointerEntered](uielement_pointerentered.md) events in slightly different cases than touch events do. For more info, see [Mouse interactions](http://msdn.microsoft.com/library/c8a158ef-70a9-4ba2-a270-7d08125700ac).

### PointerEntered for touch input

A touch point is only detectable if a finger is touching the surface. Whenever a touch action results in a [PointerPressed](uielement_pointerpressed.md) event, that event is immediately preceded by a [PointerEntered](uielement_pointerentered.md) event, with all the event data being the same information for the two events (same pointer ID, same position, and so on.) In other words the pointer is considered to enter the element at the moment and position that the element is touched by a touch point.

Alternatively, a touch point will generate [PointerEntered](uielement_pointerentered.md) if a pointer remains in constant contact with the surface as it moves, and enters the hit testing bounds of an element. For these kinds of touch actions it's also possible that the action could be processed as a manipulation, or as a gesture, rather than a pointer event. For more info, see [Quickstart: Touch input](http://msdn.microsoft.com/library/f10bafee-8792-4a57-ae84-aa11ab95355a).

### Routed event behavior for PointerEntered

[PointerEntered](uielement_pointerentered.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832). You can define multiple [PointerEntered](uielement_pointerentered.md) events for elements in a XAML UI, including for elements that are in a parent-child relationship. In a typical UI composition, the child elements are somewhere within a parent element's bounds, so the [PointerEntered](uielement_pointerentered.md) event will first occur for the parent when the pointer moves into the parent, and then for the child when the pointer moves there. The [PointerEntered](uielement_pointerentered.md) event doesn't typically bubble to the parent when the child element fires it, because conceptually the pointer is already within the parent bounds and it would be confusing for the input system to route the [PointerEntered](uielement_pointerentered.md) event occurrence to the parent too. Typically you don't want [PointerEntered](uielement_pointerentered.md) events to route anyways, you only want to process them from the sender. You can explicitly prevent event routing by setting [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md) to **true** in your handler.

In rare cases it's possible to see a [PointerEntered](uielement_pointerentered.md) event bubble to the parent. For example, if you've used a [RenderTransform](uielement_rendertransform.md) to offset a child element outside the bounds of its parent, the event bubbles to the parent when the child element is entered, and gives the event info as reported by how the child element fired the event.

### Pointer capture

If another element has captured the pointer, [PointerEntered](uielement_pointerentered.md) won't fire even if the captured pointer enters an element's bounds. However, if pointer capture is released while the pointer is over the element, [PointerEntered](uielement_pointerentered.md) will then fire, even thought the pointer might have remained stationary in this case. The value of [GetCurrentPoint](../windows.ui.xaml.input/pointerroutedeventargs_getcurrentpoint.md) from event data might be a point somewhere in the middle of an element rather than a point along its edges because the pointer was already over the element when capture was released. For more info on pointer capture, see [CapturePointer](uielement_capturepointer.md) or [Mouse interactions](http://msdn.microsoft.com/library/c8a158ef-70a9-4ba2-a270-7d08125700ac).

### PointerOver visual states for controls

Controls that have control templates can apply visual states that are active only when a pointer is over the bounds of the control. You don't always need to handle [PointerEntered](uielement_pointerentered.md) or [PointerExited](uielement_pointerexited.md) to get or change this behavior. You may need to retemplate the control. If you are deriving from an existing control that already has the low-level input handling that invokes visual states, you should provide a visual state named "PointerOver" in the "CommonStates"  [VisualStateGroup](visualstategroup.md), and the built-in control logic will load that visual state whenever a pointer is over the control. A visual state for pointer-over is often present on controls that can be invoked or selected, like a [Button](../windows.ui.xaml.controls/button.md) or [ListViewItem](../windows.ui.xaml.controls/listviewitem.md). If you're deriving from a base class like [Control](../windows.ui.xaml.controls/control.md) that doesn't have built-in input event handling that invokes visual states, you may need to override [OnPointerEntered](../windows.ui.xaml.controls/control_onpointerentered.md) and [OnPointerExited](../windows.ui.xaml.controls/control_onpointerexited.md) yourself to get this behavior. For more info, see [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4).


<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 465675-->
### Windows 8 behavior

For Windows 8, generally the [PointerEntered](uielement_pointerentered.md) event won't fire if the onscreen cursor (or stylus or touchpoint) did not actually move. For example, [PointerEntered](uielement_pointerentered.md) doesn't fire if the mouse and its onscreen cursor remains stationary, and an object with a [PointerEntered](uielement_pointerentered.md) handler has its position translated or otherwise adjusted to move underneath the onscreen cursor. Or, [PointerEntered](uielement_pointerentered.md) doesn't fire if an element like a popup or flyout disappears and the pointer is now over a new element (but pointer hasn't moved yet). Related to this is the [PointerExited](uielement_pointerexited.md) behavior. For example, if a popup is dismissed programmatically, it won't fire [PointerExited](uielement_pointerexited.md) if the pointer didn't move as the cause of dismissing it. You would still get a [PointerEntered](uielement_pointerentered.md) event if the pointer moves while over the newly revealed element, but that's up to the user whether that will happen, and it happens at the time of movement, not the moment of dismissal. In short, trying to use the last element that fired [PointerEntered](uielement_pointerentered.md) for pointer state determination in the app UI isn't comprehensive in Windows 8, and there are many scenarios where [PointerEntered](uielement_pointerentered.md) and [PointerExited](uielement_pointerexited.md) won't pair up. This impacts the visual states for controls that use [PointerEntered](uielement_pointerentered.md) and [PointerExited](uielement_pointerexited.md) as triggers also.

Starting with Windows 8.1, [PointerExited](uielement_pointerexited.md) is fired for any case where the pointer had at one time fired a [PointerEntered](uielement_pointerentered.md) event, but some UI state change happens where the pointer is no longer within that element. This includes cases where the whole element disappears. And if the pointer is now over a different element because a previous element disappeared, that element fires [PointerEntered](uielement_pointerentered.md), even if the pointer never moves. Elements that set their [Visibility](uielement_visibility.md) to **Collapsed** programmatically is one way that elements might disappear from UI, and the Windows 8.1 behavior accounts for this and will fire [PointerExited](uielement_pointerexited.md) for the **Collapsed ** element and [PointerEntered](uielement_pointerentered.md) for the newly revealed element.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in [PointerExited](uielement_pointerexited.md) and [PointerEntered](uielement_pointerentered.md) being fired in cases where they wouldn't have fired before.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[OnPointerEntered](../windows.ui.xaml.controls/control_onpointerentered.md), [PointerExited](uielement_pointerexited.md), [Quickstart: Touch input](http://msdn.microsoft.com/library/f10bafee-8792-4a57-ae84-aa11ab95355a), [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82), [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832), [XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=231524)