---
-api-id: E:Windows.System.DispatcherQueue.ShutdownStarting
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler ShutdownStarting<DispatcherQueue, DispatcherQueueShutdownStartingEventArgs>
-->

# Windows.System.DispatcherQueue.ShutdownStarting

## -description
Fires before the dispatcher queue initiates an exit from its event loop.

Equivalent WinUI event: [Microsoft.System.DispatcherQueue.ShutdownStarting](/windows/winui/api/microsoft.system.dispatcherqueue.shutdownstarting).

## -remarks
The event is fired on the thread running the **DispatcherQueue** event loop.

This event fires before the **DispatcherQueue** initiates the exit from the event loop. Event handlers for this event can queue work from within the handler. The event handler can take a deferral and continue to post work to the **DispatcherQueue** until the deferral completes. Once the deferral completes, no new work will be accepted by the **DispatcherQueue**.

## -see-also

## -examples
```csharp
_dispatcherQueue.ShutdownStarting += (s, e) =>
{
    // Queue is shutting down, do this last operation to  
    // update state before the dispatcher loop exits
    _queue.TryEnqueue(
        () =>
        {
            // clean up state
        });
};
```
