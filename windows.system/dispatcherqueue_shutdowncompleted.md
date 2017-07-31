---
-api-id: E:Windows.System.DispatcherQueue.ShutdownCompleted
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler ShutdownCompleted<DispatcherQueue,  object>
-->

# Windows.System.DispatcherQueue.ShutdownCompleted

## -description
Fires after the **DispatcherQueue** event loop stops which is the last step in the **DispatcherQueue** shutdown process.

## -remarks
The event is fired on the thread running the **DispatcherQueue** event loop. After this event is fired, any work posted to the **DispatcherQueue** will not be scheduled.

## -see-also

## -examples
```csharp
// Invoked after the DispatcherQueue event loop exits.
_dispatcherQueue.ShutdownCompleted += (s, e) =>
{
    // clean up state
};
```
