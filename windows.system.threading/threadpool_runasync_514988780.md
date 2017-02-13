---
-api-id: M:Windows.System.Threading.ThreadPool.RunAsync(Windows.System.Threading.WorkItemHandler,Windows.System.Threading.WorkItemPriority)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RunAsync(Windows.System.Threading.WorkItemHandler handler, Windows.System.Threading.WorkItemPriority priority)
-->

# Windows.System.Threading.ThreadPool.RunAsync

## -description
Creates a work item and specifies its priority relative to other work items in the thread pool.

## -parameters
### -param handler
The method to call when a thread becomes available to run the work item.

### -param priority
The priority of the work item relative to other work items in the thread pool. The value of this parameter can be **Low**, **Normal**, or **High**.

## -returns
An [IAsyncAction](../windows.foundation/iasyncaction.md) interface that provides access to the work item.

## -remarks

## -examples

## -see-also
[RunAsync(WorkItemHandler)](threadpool_runasync_527583240.md)