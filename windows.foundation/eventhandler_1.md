---
-api-id: T:Windows.Foundation.EventHandler`1
-api-type: winrt delegate
--- 
<!-- Delegate syntax.
public delegate void EventHandler<T>(System.Object sender, T args)
-->
# Windows.Foundation.EventHandler<T>

## -description
Represents a method that handles general events.

> **.NET**
> This type appears as [System.EventHandler&lt;TEventArgs&gt;](/dotnet/api/system.eventhandler-1?view=dotnet-uwp-10.0&preserve-view=true).

## -parameters
### -param sender
The event source.

### -param args
The event data.


## -remarks
When programming with .NET, this class is hidden and developers should use the [System.EventHandler&lt;TEventArgs&gt;](/dotnet/api/system.eventhandler-1?view=dotnet-uwp-10.0&preserve-view=true) class. Existing Windows Runtime events have an event data type constraint for **TEventArgs**, so use that event-data type if you need the event data in your specific handler implementation.

## -examples

## -see-also
[System.EventHandler&lt;TEventArgs&gt;](/dotnet/api/system.eventhandler-1?view=dotnet-uwp-10.0&preserve-view=true), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview)
