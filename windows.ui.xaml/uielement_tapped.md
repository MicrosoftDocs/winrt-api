---
-api-id: E:Windows.UI.Xaml.UIElement.Tapped
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.TappedEventHandler Tapped
-->

# Windows.UI.Xaml.UIElement.Tapped

## -description

Occurs when an otherwise unhandled **Tap** interaction occurs over the hit test area of this element.



## -xaml-syntax

```xaml
<uiElement Tapped="eventhandler"/>
```

## -remarks

Touch, mouse devices and pen devices can all produce a **Tap** action. For more info, see [Handle pointer input](/windows/uwp/design/input/handle-pointer-input).

See [Touch interaction design](/windows/uwp/design/input/touch-interactions) for more info on how to use a **Tap** interaction in your app design. The general idea is that a **Tap** interaction on an element invokes the element's primary action in your app.

A Tapped event represents a gesture, whereas a [PointerPressed](uielement_pointerpressed.md) event is a lower-level input event. Tapped and [PointerPressed](uielement_pointerpressed.md) events can be raised as the result of a single user interaction. If the event source has a nondefault [ManipulationMode](uielement_manipulationmode.md), [ManipulationStarting](uielement_manipulationstarting.md) can be raised too. Even if a control is already handling [PointerPressed](uielement_pointerpressed.md) in the control logic, or is handling manipulations, that doesn't prevent Tapped from being raised.

A Tapped event is potentially the result of more than one pointer point. For the higher-level gesture events such as Tapped you no longer have immediate access to [PointerPoint](../windows.ui.input/pointerpoint.md) details such as individual [PointerId](../windows.ui.input/pointerpoint_pointerid.md) values or individual coordinates. You do have access to device type ([PointerDeviceType](../windows.ui.xaml.input/tappedroutedeventargs_pointerdevicetype.md)) and for coordinates you can call [GetPosition](../windows.ui.xaml.input/tappedroutedeventargs_getposition_1813281865.md), which gives an average of the coordinates for a **Tap** from more than one pointer point.

Tapped is a routed event. Also, an element must have [IsTapEnabled](uielement_istapenabled.md) be **true** to be a Tapped event source (**true** is the default). It is possible to handle Tapped on parent elements even if [IsTapEnabled](uielement_istapenabled.md) is **false** on the parent element, if the event bubbles to a parent from an event source child element where [IsTapEnabled](uielement_istapenabled.md) is **false**. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Tapped supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked **Handled**. See [AddHandler](uielement_addhandler_2121467075.md).

Specific Windows Runtime controls may also have class-based handling for the Tapped event. If so, the control probably has an override for the method [OnTapped](../windows.ui.xaml.controls/control_ontapped_449778764.md). For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Tapped and [Holding](uielement_holding.md) are mutually exclusive. The input system must wait until the pointer point is released in order to determine whether the action should be Tapped, [Holding](uielement_holding.md) or some other gesture, so you don't get Tapped at the very instant that a user touches the screen. If you really need instant feedback you may want to use [PointerPressed](uielement_pointerpressed.md) instead.

If a user interaction also raises [DoubleTapped](uielement_doubletapped.md), Tapped will be raised first to represent the first tap, but the second tap won't raise an additional Tapped. If you want different logic for Tapped versus [DoubleTapped](uielement_doubletapped.md), your Tapped handler may need to use app-specific variables and a timer in order to avoid running on interactions that are eventually interpreted as a **DoubleTap** action.

### Tapped for mouse and pen/stylus input

The input system processes an action where the user clicks the left mouse button while over the element as a Tapped action. The event doesn't fire until the left mouse button is released. Mouse input doesn't produce [Holding](uielement_holding.md) events by default, no matter how long a mouse button is held down, or which button is held.

For pen devices, touching the pen device to the surface and remaining in one place produces a **Hold** action.

### Controls that do not raise the Tapped event

These controls do not raise the **Tapped** event:

+ [PasswordBox](../windows.ui.xaml.controls/passwordbox.md)
+ [RichEditBox](../windows.ui.xaml.controls/richeditbox.md)
+ [TextBox](../windows.ui.xaml.controls/textbox.md)

## -examples

## -see-also

[TappedRoutedEventArgs](../windows.ui.xaml.input/tappedroutedeventargs.md), [IsTapEnabled](uielement_istapenabled.md), [PointerPressed](uielement_pointerpressed.md), [DoubleTapped](uielement_doubletapped.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
