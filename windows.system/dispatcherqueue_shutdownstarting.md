---
-api-id: E:Windows.System.DispatcherQueue.ShutdownStarting
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler ShutdownStarting<DispatcherQueue, DispatcherQueueShutdownStartingEventArgs>
-->

# Windows.System.DispatcherQueue.ShutdownStarting

## -description

Raised when [ShutdownQueueAsync](dispatcherqueuecontroller_shutdownqueueasync_542547627.md) is called. For a full list of the events raised, and in what order, see the Remarks for [ShutdownQueueAsync](dispatcherqueuecontroller_shutdownqueueasync_542547627.md).

## -remarks

The **ShutdownStarting** event is raised from the event loop thread *before* the event loop exits. The handler for this event can take a deferral, and can continue to post work until the deferral completes. Once the deferral completes, the **DispatcherQueue** no longer accepts work, and [DispatcherQueue.TryEnqueue](dispatcherqueue_tryenqueue_591440238.md) returns `false`.

## -see-also

[ShutdownQueueAsync](dispatcherqueuecontroller_shutdownqueueasync_542547627.md), [DispatcherQueue.TryEnqueue](dispatcherqueue_tryenqueue_591440238.md)

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
