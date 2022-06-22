---
-api-id: E:Windows.UI.Xaml.UIElement.ManipulationStarting
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.ManipulationStartingEventHandler ManipulationStarting
-->

# Windows.UI.Xaml.UIElement.ManipulationStarting

## -description

Occurs when the manipulation processor is first created.



## -xaml-syntax

```xaml
<uiElement ManipulationStarting="eventhandler"/>
```

## -remarks

For custom controls and interaction experiences, see [GestureRecognizer](../windows.ui.input/gesturerecognizer.md).

An element must have a [ManipulationMode](uielement_manipulationmode.md) value other than **None** or **System** to be a manipulation event source. The default value of [ManipulationMode](uielement_manipulationmode.md) is **System**, which enables built-in control logic to process manipulations, but doesn't permit app code to handle manipulation events. If you want to handle manipulations, set [ManipulationMode](uielement_manipulationmode.md) to **All**, or to specific [ManipulationModes](../windows.ui.xaml.input/manipulationmodes.md) values. For more info, see [ManipulationMode](uielement_manipulationmode.md).

ManipulationStarting fires basically any time that a pointer interacts with an element where the element enables manipulation. This includes cases where the manipulation is interpreted as a gesture and the pointers never move, for example a [Tapped](uielement_tapped.md) or [Holding](uielement_holding.md) gesture. If the pointers do move, [ManipulationStarted](uielement_manipulationstarted.md) typically fires thereafter.

ManipulationStarting is a routed event. If the event is permitted to bubble up to parent elements because it goes unhandled, then it is possible to handle the event on parent elements even if [ManipulationMode](uielement_manipulationmode.md) is **None** or **System** on the parent element. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

ManipulationStarting supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/manipulationstartingroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

### Windows 8 behavior

Windows 8 had an issue with firing this event if multiple gestures happened in a short period of time. For example, Windows 8 might only fire ManipulationStarting for the first gesture and not the second. The issue is fixed starting with Windows 8.1; multiple starting gestures processed by the input system each fire a distinct ManipulationStarting event.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also

[ManipulationStartingRoutedEventArgs](../windows.ui.xaml.input/manipulationstartingroutedeventargs.md), [OnManipulationStarting](../windows.ui.xaml.controls/control_onmanipulationstarting_1590761399.md), [ManipulationStarted](uielement_manipulationstarted.md), [Using manipulation events](/previous-versions/windows/apps/hh465387(v=win.10)), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
