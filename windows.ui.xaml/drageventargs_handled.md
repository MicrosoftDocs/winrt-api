---
-api-id: P:Windows.UI.Xaml.DragEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.DragEventArgs.Handled

## -description
Gets or sets a value that indicates the present state of the event handling for a routed event as it travels the route.



## -property-value
**true** if the event is marked handled; otherwise, **false**. The default value is **false**.

## -remarks
The events that use [DragEventArgs](drageventargs.md) for event data are routed events. Setting the value of the Handled property to **true** from an event handler can influence how a routed event behaves: it prevents handlers further along the route from being invoked. However, a handler that was attached by calling [AddHandler](uielement_addhandler_2121467075.md) with *handledEventsToo* is still invoked. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -examples

## -see-also
[Drag-and-drop overview](/windows/uwp/design/input/drag-and-drop), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview)
