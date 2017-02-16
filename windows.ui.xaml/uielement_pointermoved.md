---
-api-id: E:Windows.UI.Xaml.UIElement.PointerMoved
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.PointerEventHandler PointerMoved
-->

# Windows.UI.Xaml.UIElement.PointerMoved

## -description
Occurs when a pointer moves while the pointer remains within the hit test area of this element.

## -xaml-syntax
```xaml
<uiElement PointerMoved="eventhandler"/>
```


## -remarks
Touch, mouse, and pen/stylus interactions are received, processed, and managed as pointer input in Windows Store app. Any of these interactions can produce a [PointerMoved](uielement_pointermoved.md) event. For more info, see [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82) and the "PointerMoved for mouse and stylus input" section of this topic.

In some UI scenarios, particularly if the user is using a mouse, this event will fire a lot. Be aware of the performance profile for code you put into this handler, and consider ways to use your own flags or tolerances that can throttle how many times the logic actually needs to run.

This event is a routed event. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

This event also supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked **Handled**. See [AddHandler](uielement_addhandler.md).

### PointerMoved for mouse and stylus input

A mouse input device has an onscreen cursor that is visible whenever the mouse moves over an element's bounds, even if no mouse button is pressed at the time. Similar behavior is available for pen device input, where the input devices can detect that the pen is hovering just over the input device surface but not touching it. Mouse and pen input will thus fire [PointerMoved](uielement_pointermoved.md) events more often than touch input. For more info, see [Mouse interactions](http://msdn.microsoft.com/library/c8a158ef-70a9-4ba2-a270-7d08125700ac).

In contrast, a touch point is only detectable if a finger is touching the surface. A touch point will generate [PointerMoved](uielement_pointermoved.md) only while that touch point remains in constant contact with the surface as it moves. For these kinds of touch actions that are generating [PointerMoved](uielement_pointermoved.md) it's also likely that the action will be processed as a manipulation, or as a gesture. For more info, see [Quickstart: Touch input](http://msdn.microsoft.com/library/f10bafee-8792-4a57-ae84-aa11ab95355a).

Mouse input is associated with a single pointer assigned when mouse input is first detected, and all mouse-initiated interactions have the same [PointerId](../windows.ui.input/pointerpoint_pointerid.md). Clicking a mouse button (left, wheel, or right) creates a secondary association between the pointer and that button through the [PointerPressed](uielement_pointerpressed.md) event. The [PointerReleased](uielement_pointerreleased.md) event is fired only when that same mouse button is released (no other button can be associated with the pointer until this event is complete). Because of this exclusive association, other mouse button clicks are routed through the [PointerMoved](uielement_pointermoved.md) event. You can test the mouse button state when handling this event, as shown in this example:



[!code-csharp[PointerMoved](../windows.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetPointerMoved)]

[!code-csharp[PointerMoved](../windows.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml.cs#SnippetPointerMoved)]

## -examples

## -see-also
[PointerEntered](uielement_pointerentered.md), [OnPointerMoved](../windows.ui.xaml.controls/control_onpointermoved.md), [Quickstart: Touch input](http://msdn.microsoft.com/library/f10bafee-8792-4a57-ae84-aa11ab95355a), [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82), [XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=231524)
soft.com/fwlink/p/?linkid=231524)
