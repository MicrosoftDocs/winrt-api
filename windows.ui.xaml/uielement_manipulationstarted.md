---
-api-id: E:Windows.UI.Xaml.UIElement.ManipulationStarted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.ManipulationStartedEventHandler ManipulationStarted
-->

# Windows.UI.Xaml.UIElement.ManipulationStarted

## -description

Occurs when an input device begins a manipulation on the [UIElement](uielement.md).

## -xaml-syntax

```xaml
<uiElement ManipulationStarted="eventhandler"/>
```

## -remarks

For custom controls and interaction experiences, see [GestureRecognizer.ManipulationStarted](../windows.ui.input/gesturerecognizer_manipulationstarted.md).

[ManipulationStarted](uielement_manipulationstarted.md) represents that the manipulation recognition logic has detected pointer movement. In this case it's the second manipulation event to fire in a typical sequence, firing after ManipulationStarting, but before ManipulationDelta or other events such as ManipulationInertiaStarting.

An element must have a [ManipulationMode](uielement_manipulationmode.md) value other than **None** or **System** to be a manipulation event source. The default value of [ManipulationMode](uielement_manipulationmode.md) is **System**, which enables built-in control logic to process manipulations, but doesn't permit app code to handle manipulation events. If you want to handle manipulations, set [ManipulationMode](uielement_manipulationmode.md) to **All**, or to specific [ManipulationModes](../windows.ui.xaml.input/manipulationmodes.md) values. For more info, see [ManipulationMode](uielement_manipulationmode.md).

[ManipulationStarted](uielement_manipulationstarted.md) is a routed event. If the event is permitted to bubble up to parent elements because it goes unhandled, then it is possible to handle the event on parent elements even if [ManipulationMode](uielement_manipulationmode.md) is **None** or **System** on the parent element. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

[ManipulationStarted](uielement_manipulationstarted.md) supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/manipulationstartedroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

## -examples

## -see-also

[ManipulationStartedRoutedEventArgs](../windows.ui.xaml.input/manipulationstartedroutedeventargs.md), [OnManipulationStarted](../windows.ui.xaml.controls/control_onmanipulationstarted_1992945826.md), [ManipulationStarting](uielement_manipulationstarting.md), [Using manipulation events](http://msdn.microsoft.com/library/f10bafee-8792-4a57-ae84-aa11ab95355a), [XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=231524)