---
-api-id: T:Windows.System.DispatcherQueueHandler
-api-type: winrt delegate
---

<!-- Delegate syntax.
public delegate void DispatcherQueueHandler()
-->

# Windows.System.DispatcherQueueHandler


## -description

A callback that will be executed on the **DispatcherQueue** thread.

## -remarks

## -see-also

## -examples

The following example demonstrates how to create a **DispatcherQueueHandler** that can be used to run code on a thread with [DispatcherQueue](dispatcherqueue.md) and how to enqueue it using [TryEnqueue](dispatcherqueue_tryenqueue_591440238.md).

```csharp
Windows.System.DispatcherQueueHandler handler = () =>
                                {
                                    // code for DispatcherQueue to run
                                };

// Create a new thread and initialize a DispatcherQueueController
// and run a DispatcherQueue event loop on it.
_queueController =
    DispatcherQueueController.CreateOnDedicatedThread();
_queue = _queueController.DispatcherQueue;

// This is the first TryEnqueue() after creating the DispatcherQueue
// The callback is guaranteed to be invoked first despite Priority on the
// newly created thread.

// Attempt to enqueue the handler and check if it was successful
if (_queue.TryEnqueue(handler))
{
    // The handler was successfully enqueued
    Console.WriteLine("Handler enqueued successfully.");
}
else
{
    // The handler could not be enqueued, because
    // ShutdownQueueAsync() was called on the DispatcherQueueController
    // or the DispatcherQueue is no longer active.
    Console.WriteLine("Failed to enqueue handler.");
}
```
