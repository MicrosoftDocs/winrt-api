---
-api-id: M:Windows.System.DispatcherQueueController.ShutdownQueueAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction DispatcherQueueController.ShutdownQueueAsync()
-->

# Windows.System.DispatcherQueueController.ShutdownQueueAsync

## -description

Asynchronously stops the [DispatcherQueue](./dispatcherqueue.md) associated with this [DispatcherQueueController](./dispatcherqueuecontroller.md), and shuts down the thread if the **DispatcherQueueController** was created by [CreateOnDedicatedThread](dispatcherqueuecontroller_createondedicatedthread_660689653.md).

This method returns (an asynchronous operation) as soon as the shutdown operation is started; but the asynchronous operation doesn't complete until the shutdown operation is complete.

## -returns

An asynchronous operation, which will complete after the queue has dispatched all of its remaining work.

## -remarks

When you call **ShutdownQueueAsync**, the following events are raised, in this order:

* [ShutdownStarting](./dispatcherqueue_shutdownstarting.md)
* [ShutdownCompleted](./dispatcherqueue_shutdowncompleted.md)

Those events are members of the [DispatcherQueue](./dispatcherqueue.md) object, and their purpose is to notify listeners that the **DispatcherQueue** is shutting down. The events are raised on the thread running the **DispatcherQueue** event loop itself.

## -see-also

## -examples

```csharp
// Shutdown the event loop
public async void ShutdownLoop()
{
    if (_queueController != null)
    {
        // The await will complete after the event loop exits
        await _queueController.ShutdownQueueAsync();
        _queueController = null;
        _queue = null;
    }
}

// Another class that has access to the dedicated thread’s DispatcherQueue.
public class ModuleA
{
    public async void ShutdownSetup()
    {
        // Gets the DispatcherQueue for the dedicated thread

        // Invoked when controller begins the ShutdownQueueAsync.
        _dispatcherQueue.ShutdownStarting += (s, e) =>
        {
            // Queue is shutting down, do this last operation which
            // will update state before the loop exits
            _queue.TryEnqueue(
                () =>
                {
                    FinalInThreadCleanup(_myState);
                });
        };

        // Invoked after the DispatcherQueue event loop exits.
        _dispatcherQueue.ShutdownCompleted += (s, e) =>
        {
            CleanUp(_myState);
        };
    }
}
```
