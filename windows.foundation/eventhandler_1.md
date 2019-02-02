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
> This type appears as [System.EventHandler&lt;TEventArgs&gt;](https://msdn.microsoft.com/library/windows/apps/db0etb8x).

## -parameters
### -param sender
The event source.

### -param args
The event data.


## -remarks
When programming with .NET, this class is hidden and developers should use the [System.EventHandler&lt;TEventArgs&gt;](https://msdn.microsoft.com/library/windows/apps/db0etb8x) class. Existing Windows Runtime events have an event data type constraint for **TEventArgs**, so use that event-data type if you need the event data in your specific handler implementation.

## -examples

## -see-also
[System.EventHandler&lt;TEventArgs&gt;](https://msdn.microsoft.com/library/windows/apps/db0etb8x), [Events and routed events overview](https://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832)
