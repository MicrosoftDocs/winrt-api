---
-api-id: E:Windows.System.DispatcherQueue.ShutdownCompleted
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler ShutdownCompleted<DispatcherQueue,  object>
-->

# Windows.System.DispatcherQueue.ShutdownCompleted

## -description

Raised when [ShutdownQueueAsync](./dispatcherqueuecontroller_shutdownqueueasync_542547627.md) is called. For a full list of the events raised, and in what order, see the Remarks for [ShutdownQueueAsync](./dispatcherqueuecontroller_shutdownqueueasync_542547627.md).

## -remarks

The **ShutdownCompleted** event is raised from the event loop thread *after* the event loop has exited. You can use the handler for this event to clean up any state maintained by partner components that were maintained on the dedicated thread.

## -see-also

## -examples

```csharp
// Invoked after the DispatcherQueue event loop exits.
_dispatcherQueue.ShutdownCompleted += (s, e) =>
{
    // clean up state
};
```
