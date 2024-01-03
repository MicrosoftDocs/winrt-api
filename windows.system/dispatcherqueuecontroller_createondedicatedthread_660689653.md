---
-api-id: M:Windows.System.DispatcherQueueController.CreateOnDedicatedThread
-api-type: winrt method
---

<!-- Method syntax.
public DispatcherQueueController DispatcherQueueController.CreateOnDedicatedThread()
-->

# Windows.System.DispatcherQueueController.CreateOnDedicatedThread

## -description
Creates a [DispatcherQueue](dispatcherqueue.md) that you can use to run tasks on a dedicated thread.

## -returns
The created **DispatcherQueueController**.

## -remarks
You can access the created **DispatcherQueue** via [DispatcherQueueController.DispatcherQueue](dispatcherqueuecontroller_dispatcherqueue.md).

The created **DispatcherQueue** continues running on its dedicated thread until explicitly shut down.
To avoid thread and memory leaks,
call [DispatcherQueueController.ShutdownQueueAsync](dispatcherqueuecontroller_shutdownqueueasync_542547627.md)
when you are finished with the **DispatcherQueue**.

## -see-also

## -examples
