---
-api-id: M:Windows.UI.Xaml.UIElement.RemoveHandler(Windows.UI.Xaml.RoutedEvent,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void RemoveHandler(Windows.UI.Xaml.RoutedEvent routedEvent, System.Object handler)
-->

# Windows.UI.Xaml.UIElement.RemoveHandler

## -description
Removes the specified routed event handler from this [UIElement](uielement.md). Typically the handler in question was added by [AddHandler](uielement_addhandler_2121467075.md).



## -parameters
### -param routedEvent
The identifier of the routed event for which the handler is attached.

### -param handler
The specific handler implementation to remove from the event handler collection on this [UIElement](uielement.md).

## -remarks
RemoveHandler can only be used for the event handlers of the events that are supported by [AddHandler](uielement_addhandler_2121467075.md), which is approximately the input-specific events of [UIElement](uielement.md). More precisely, the event must have a ***Event** property of type [RoutedEvent](routedevent.md), which is true only of certain events on [UIElement](uielement.md). You cannot use RemoveHandler to unhook event handlers for Windows Runtime events on runtime class instances in general. Instead, you should use the specific event handler unhooking syntax: 
+ `-=` in C#
+ **RemoveHandler** in Microsoft Visual Basic
+ `-=` in Visual C++ component extensions (C++/CX)

<!--

If more than one handler is attached that matched the criteria, only the first handler in the event handler store is removed. This behavior is consistent with CLR behavior of the -= operator.  

-->

Calling this method has no effect if there were no handlers registered with criteria that match the input parameters for the method call.

This method ignores whether *handledEventsToo* parameter was **true** in the [AddHandler](uielement_addhandler_2121467075.md) call that originally attached the handler.

## -examples

## -see-also
[AddHandler](uielement_addhandler_2121467075.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [RoutedEvent](routedevent.md)
