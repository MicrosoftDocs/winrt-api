---
-api-id: M:Windows.System.DispatcherQueue.TryEnqueue(Windows.System.DispatcherQueuePriority,Windows.System.DispatcherQueueHandler)
-api-type: winrt method
---

<!-- Method syntax.
public bool DispatcherQueue.TryEnqueue(DispatcherQueuePriority priority, DispatcherQueueHandler callback)
-->

# Windows.System.DispatcherQueue.TryEnqueue

## -description
Adds a task to the **DispatcherQueue** which will be executed on the thread associated with the **DispatcherQueue**.

Equivalent WinUI method: [Microsoft.System.DispatcherQueue.TryEnqueue](/windows/winui/api/microsoft.system.dispatcherqueue.tryenqueue).

## -parameters
### -param priority
The priority of the task such as Low, Normal, or High.

### -param callback
A delegate to the task to execute.

## -returns
**True** indicates that the task was added to the queue; **false**, otherwise.

## -remarks
The queue will invoke **callback** serially and in priority order.

Once [ShutdownQueueAsync()](dispatcherqueuecontroller_shutdownqueueasync_542547627.md) has been called, the queue will not queue new tasks and this method will return **false**.

## -see-also

## -examples

```csharp
// Create a new thread and initialize a DispatcherQueueController
// and run a DispatcherQueue event loop on it.

_queueController =
    DispatcherQueueController.CreateOnDedicatedThread();
_queue = _queueController.DispatcherQueue;

// This is the first TryEnqueue() after creating the DispatcherQueue. The
// first TryEnqueue task is guaranteed //to be invoked first on the new
// thread, regardless of what priority it was enqueued at.


bool isQueued = _queue.TryEnqueue(Windows.System.DispatcherQueuePriority.High,
        () =>
        {
            // task to perform on another thread.
        });
```
