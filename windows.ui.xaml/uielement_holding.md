---
-api-id: E:Windows.UI.Xaml.UIElement.Holding
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.HoldingEventHandler Holding
-->

# Windows.UI.Xaml.UIElement.Holding

## -description

Occurs when an otherwise unhandled **Hold** interaction occurs over the hit test area of this element.



## -xaml-syntax

```xaml
<uiElement Holding="eventhandler"/>
```

## -remarks

Touch can produce a **Holding** action, but mouse devices generally can't. For more info, see [Handle pointer input](/windows/uwp/design/input/handle-pointer-input).

The [Tapped](uielement_tapped.md), [DoubleTapped](uielement_doubletapped.md), and [RightTapped](uielement_righttapped.md) events occur only after the touch point is removed. But the initial Holding event occurs while the touch point is still in contact. The event occurs if the touch point remains in approximately the same [PointerPoint](../windows.ui.input/pointerpoint.md) position for a period of time. The exact timing of what the system interprets as a holding action is adjustable by users through system settings.

Holding is intended for informational UI, but for interactions like displaying a context menu you should use [RightTapped](uielement_righttapped.md) instead. You might handle Holding first to display a hint that a menu will appear, but to display the menu itself, use a [RightTapped](uielement_righttapped.md) handler. See [Touch interaction design](https://msdn.microsoft.com/library/9ba7f613-e5d1-40d4-920b-143094209e3a) or [UX guidelines for custom user interactions](/windows/uwp/design/layout/index) for more info on how to use a **Hold** interaction in your app design.

Holding events generally occur in pairs. When the action is first interpreted as a **Hold** action based on no movement for a period of time, Holding fires, with [HoldingState](../windows.ui.input/holdingeventargs_holdingstate.md) value of **Started** in the [HoldingRoutedEventArgs](../windows.ui.xaml.input/holdingroutedeventargs.md) event data. When the **Hold** action ends, another Holding event fires, this time with [HoldingState](../windows.ui.input/holdingeventargs_holdingstate.md) of either **Completed** or **Canceled**.

+ The **Hold** action ends with [HoldingState](../windows.ui.input/holdingeventargs_holdingstate.md) as **Completed** if the user doesn't move the pointer during the **Hold** state and then releases the pointer points that initiated the action. For this case, [RightTapped](uielement_righttapped.md) fires just after the second Holding event.

+ The **Hold** action ends with [HoldingState](../windows.ui.input/holdingeventargs_holdingstate.md) as **Canceled** if the user does move the pointer(s) that initiated the action, or also for uncommon situations such as changing the hit-test status on the element during the action or capturing another pointer. If the **Hold** action ends with [HoldingState](../windows.ui.input/holdingeventargs_holdingstate.md) as **Canceled**, [RightTapped](uielement_righttapped.md) won't fire.

A Holding event represents a gesture, whereas a [PointerPressed](uielement_pointerpressed.md) event is a lower-level input event. Holding and [PointerPressed](uielement_pointerpressed.md) events can fire as the result of a single user interaction. Even if a control is already handling pointer events in the control logic, or is handling manipulations, that doesn't prevent Holding from firing.

A Holding event is potentially the result of more than one pointer point. For the higher-level gesture events like Holding you no longer have immediate access to [PointerPoint](../windows.ui.input/pointerpoint.md) details such as individual [PointerId](../windows.ui.input/pointerpoint_pointerid.md) values or individual coordinates. You do have access to device type ([PointerDeviceType](../windows.ui.xaml.input/holdingroutedeventargs_pointerdevicetype.md)) and for coordinates you can call [GetPosition](../windows.ui.xaml.input/holdingroutedeventargs_getposition_1813281865.md), which gives an average of the coordinates for a **Hold** from more than one pointer point.

Holding is a routed event. Also, an element must have [IsHoldingEnabled](uielement_isholdingenabled.md) be **true** to be a Holding event source (**true** is the default). It is possible to handle Holding on parent elements even if [IsHoldingEnabled](uielement_isholdingenabled.md) is **false** on the parent element, if the event bubbles to a parent from an event source child element where [IsHoldingEnabled](uielement_isholdingenabled.md) is **false**. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Holding supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/holdingroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

Specific Windows Runtime controls may have class-based handling for the Holding event. If so, the control probably has an override for the method [OnHolding](../windows.ui.xaml.controls/control_onholding_1052914744.md). For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

[Tapped](uielement_tapped.md) and Holding are mutually exclusive. If the action passes the time threshold to be considered a **Hold** action, it's not considered to be a **Tap** action also.

Whenever Holding fires initially, so long as the element supports manipulation events through a non-default [ManipulationMode](uielement_manipulationmode.md) value, [ManipulationStarting](uielement_manipulationstarting.md) fires too. If the pointer point remains in one place long enough for Holding to be detected, but thereafter the user moves the pointer points associated with the **Hold** action without releasing them (leading to another Holding event with [HoldingState](../windows.ui.input/holdingeventargs_holdingstate.md) as **Canceled**), then other manipulation events like [ManipulationStarted](uielement_manipulationstarted.md) and [ManipulationDelta](uielement_manipulationdelta.md) can fire also.

### Holding for mouse and pen/stylus input

Mouse input doesn't produce Holding events by default, no matter how long a mouse button is held down, or which button is held. However, mouse devices and some pen devices can fire [RightTapped](uielement_righttapped.md) when a right mouse button or equivalent is pressed and released.

> [!NOTE]
> There is a way to treat mouse actions as hold actions if you use your own [GestureRecognizer](../windows.ui.input/gesturerecognizer.md) and specify **HoldWithMouse** in settings.

## -examples

## -see-also

[HoldingRoutedEventArgs](../windows.ui.xaml.input/holdingroutedeventargs.md), [RightTapped](uielement_righttapped.md), [OnHolding](../windows.ui.xaml.controls/control_onholding_1052914744.md), [IsHoldingEnabled](uielement_isholdingenabled.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview)
