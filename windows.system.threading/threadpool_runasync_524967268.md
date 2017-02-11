---
-api-id: M:Windows.System.Threading.ThreadPool.RunAsync(Windows.System.Threading.WorkItemHandler,Windows.System.Threading.WorkItemPriority,Windows.System.Threading.WorkItemOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RunAsync(Windows.System.Threading.WorkItemHandler handler, Windows.System.Threading.WorkItemPriority priority, Windows.System.Threading.WorkItemOptions options)
-->

# Windows.System.Threading.ThreadPool.RunAsync

## -description
Creates a work item, specifies its priority relative to other work items in the thread pool, and specifies how long-running work items should be run.

## -parameters
### -param handler
The method to call when a thread becomes available to run the work item.

### -param priority
The priority of the work item relative to other work items in the thread pool.

### -param options
If this parameter is **TimeSliced**, the work item runs simultaneously with other time-sliced work items with each work item receiving a share of processor time. If this parameter is **None**, the work item runs when a worker thread becomes available.

## -returns
An [IAsyncAction](../windows.foundation/iasyncaction.md) interface that provides access to the work item.

## -remarks

## -examples

## -see-also
[RunAsync(WorkItemHandler)](threadpool_runasync_527583240.md), [RunAsync(WorkItemHandler, WorkItemPriority)](threadpool_runasync_514988780.md)