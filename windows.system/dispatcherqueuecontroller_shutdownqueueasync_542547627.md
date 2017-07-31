---
-api-id: M:Windows.System.DispatcherQueueController.ShutdownQueueAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction DispatcherQueueController.ShutdownQueueAsync()
-->

# Windows.System.DispatcherQueueController.ShutdownQueueAsync

## -description
Stops the **DispatcherQueue** associated with this **DispatcherQueueController**. Shuts down the thread if the **DispatcherQueueController** was created by **CreateOnDedicatedThread**.

## -returns
An asynchronous operation which will complete after the queue has dispatched all of its remaining work.

## -remarks
After [ShutdownQueueAsync](https://microsoft.sharepoint.com/sites/infopedia/engineering) fires, two events ([DispatcherQueue.ShutdownStarting](dispatcherqueue_shutdownstarting.md) and [DispatcherQueue.ShutdownCompleted](dispatcherqueue_shutdowncompleted.md)) fire on the **DispatcherQueue** to notify listeners that the **DispatcherQueue** is shutting down. The events are fired on the thread running the **DispatcherQueue** event loop itself.

**DispatcherQueue.ShutdownStarting** fires before the event loop exits. The event handler can take a deferral and continue to post work until the deferral completes. Once the deferral completes, the **DispatcherQueue** will no longer accept work and **DispatcherQueue.TryEnqueue** will return false.  
**DispatcherQueue.ShutdownCompleted** will fire after the event loop has been exited. This event can be used to clean up any state maintained by partner components that were maintained on the dedicated thread.

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
