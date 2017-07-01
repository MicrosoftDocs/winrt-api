---
-api-id: M:Windows.System.DispatcherQueue.TryEnqueue(Windows.System.DispatcherQueueHandler)
-api-type: winrt method
---

<!-- Method syntax.
public bool DispatcherQueue.TryEnqueue(DispatcherQueueHandler callback)
-->

# Windows.System.DispatcherQueue.TryEnqueue

## -description
Adds a task to the **DispatcherQueue** which will be executed on the thread  associated with the **DispatcherQueue**.

## -parameters
### -param callback
The task to execute.

## -returns
**True** indicates that the task was added to the queue; **false**, otherwise.

## -remarks
The task will be queued at **Normal** priority. The queue will invoke **callback** serially and in priority order.

Once [ShutdownQueueAsync()](dispatcherqueuecontroller_shutdownqueueasync_542547627.md) has been called, the queue will not queue new tasks and this method will return **false**.

## -see-also

## -examples
``` csharp
// Create a new thread and initialize a DispatcherQueueController
// and run a DispatcherQueue event loop on it.

_queueController =
    DispatcherQueueController.CreateOnDedicatedThread();
_queue = _queueController.DispatcherQueue;

// This is the first TryEnqueue() after creating the DispatcherQueue
// The callback is guaranteed to be invoked first despite Priority on the
// newly created thread.

bool isQueued = _queue.TryEnqueue(
        () =>
        {
            // task to perform on another thread.
        });
```
