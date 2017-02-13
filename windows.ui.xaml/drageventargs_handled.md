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
The events that use [DragEventArgs](drageventargs.md) for event data are routed events. Setting the value of the [Handled](drageventargs_handled.md) property to **true** from an event handler can influence how a routed event behaves: it prevents handlers further along the route from being invoked. However, a handler that was attached by calling [AddHandler](uielement_addhandler.md) with *handledEventsToo* is still invoked. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

## -examples

## -see-also
[Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832)