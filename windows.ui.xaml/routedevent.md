---
-api-id: T:Windows.UI.Xaml.RoutedEvent
-api-type: winrt class
---

<!-- Class syntax.
public class RoutedEvent : Windows.UI.Xaml.IRoutedEvent
-->

# Windows.UI.Xaml.RoutedEvent

## -description
Represents a routed event to the Windows Runtime event system.



## -remarks

> [!NOTE]
> The Windows Runtime event system doesn't enable you to create a custom routed event; only the Windows Runtime itself can define an event such that it has the routed event behavior.

For more info on how routed events work, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview). The RoutedEvent type is part of the infrastructure for routed events, but you don't use RoutedEvent directly in typical Windows Runtime app programming.

The purpose of the RoutedEvent type is to serve as an identifier for the Windows Runtime event system, similar to how [DependencyProperty](dependencyproperty.md) provides an identifier type for the dependency property system. [UIElement](uielement.md) includes several static read-only properties of type RoutedEvent, which are named using a naming pattern. Each RoutedEvent property is named after an event plus the suffix "Event". Each such property is the identifier for the routed event that its name begins with. For example, [TappedEvent](uielement_tappedevent.md) identifies the [Tapped](uielement_tapped.md) routed event to the event system.

For most app code usages, simply referencing the event by name in XAML or by its code entity name in code is all that's needed to reference an event on an object, for purposes of adding or removing handlers. The RoutedEvent identifiers are only needed when you attach handlers that should be invoked even when the routed events are previously marked as handled by either system or app code. The API you use for this scenario, and the API that use a RoutedEvent value as a parameter, are [UIElement.AddHandler](uielement_addhandler_2121467075.md) and [UIElement.RemoveHandler](uielement_removehandler_661998757.md). For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

### Events that use a RoutedEvent identifier

Here's a list of the routed events that have a RoutedEvent identifier and thus can use the [UIElement.AddHandler](uielement_addhandler_2121467075.md) technique we described:

+ [DoubleTapped](uielement_doubletapped.md)
+ [DragEnter](uielement_dragenter.md)
+ [DragLeave](uielement_dragleave.md)
+ [DragOver](uielement_dragover.md)
+ [Drop](uielement_drop.md)
+ [Holding](uielement_holding.md)
+ [KeyDown](uielement_keydown.md)
+ [KeyUp](uielement_keyup.md)
+ [ManipulationCompleted](uielement_manipulationcompleted.md)
+ [ManipulationDelta](uielement_manipulationdelta.md)
+ [ManipulationInertiaStarting](uielement_manipulationinertiastarting.md)
+ [ManipulationStarted](uielement_manipulationstarted.md)
+ [ManipulationStarting](uielement_manipulationstarting.md)
+ [PointerCanceled](uielement_pointercanceled.md)
+ [PointerCaptureLost](uielement_pointercapturelost.md)
+ [PointerEntered](uielement_pointerentered.md)
+ [PointerExited](uielement_pointerexited.md)
+ [PointerMoved](uielement_pointermoved.md)
+ [PointerPressed](uielement_pointerpressed.md)
+ [PointerReleased](uielement_pointerreleased.md)
+ [PointerWheelChanged](uielement_pointerwheelchanged.md)
+ [RightTapped](uielement_righttapped.md)
+ [Tapped](uielement_tapped.md)
> [!NOTE]
> [GotFocus](uielement_gotfocus.md) and [LostFocus](uielement_lostfocus.md) act like routed events but don't have a RoutedEvent identifier, so you can't use [AddHandler](uielement_addhandler_2121467075.md) with them.

## -examples
This example shows the basic syntax for wiring an event handler with [AddHandler](uielement_addhandler_2121467075.md) and *handledEventsToo* as **true**. In this case the event being wired is [Tapped](uielement_tapped.md), and the RoutedEvent-type identifier used in the example is [TappedEvent](uielement_tappedevent.md). The typical place to wire handlers is either [Loaded](frameworkelement_loaded.md) for a page or [OnApplyTemplate](frameworkelement_onapplytemplate_1955470198.md) for a templated control.



[!code-cpp[AddHandler](../windows.ui.xaml/code/BaseElementEvents/cpp/BasicPage.xaml.cpp#SnippetAddHandler)]

[!code-csharp[AddHandler](../windows.ui.xaml/code/BaseElementEvents/csharp/BasicPage1.xaml.cs#SnippetAddHandler)]

[!code-vb[AddHandler](../windows.ui.xaml/code/BaseElementEvents/vbnet/MainPage.xaml.vb#SnippetAddHandler)]

## -see-also
[Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [UIElement.AddHandler](uielement_addhandler_2121467075.md), [UIElement.RemoveHandler](uielement_removehandler_661998757.md), [RoutedEventArgs](routedeventargs.md)
