---
-api-id: M:Windows.System.Threading.Core.PreallocatedWorkItem.#ctor(Windows.System.Threading.WorkItemHandler,Windows.System.Threading.WorkItemPriority,Windows.System.Threading.WorkItemOptions)
-api-type: winrt method
---

<!-- Method syntax
public PreallocatedWorkItem(Windows.System.Threading.WorkItemHandler handler, Windows.System.Threading.WorkItemPriority priority, Windows.System.Threading.WorkItemOptions options)
-->

# Windows.System.Threading.Core.PreallocatedWorkItem.PreallocatedWorkItem

## -description
Initializes a new work item with a [WorkItemHandler](../windows.system.threading/workitemhandler.md) delegate, allocating resources for the work item in advance, and specifies the priority of the work item relative to other work items in the thread pool. Also specifies how the thread pool will allocate processor time for the work item.

## -parameters
### -param handler
Indicates the method that the preallocated work item will run.

### -param priority
The priority of the work item relative to other work items in the thread pool. The value of this parameter can be **Low**, **Normal**, or **High**.

### -param options
If this parameter is set to **TimeSliced**, the work item runs simultaneously with other time-sliced work items, with each work item receiving a share of processor time. If this parameter is set to **None**, the work item runs when a worker thread becomes available.

## -remarks
See the remarks section of the [PreallocatedWorkItem(WorkItemHandler)](preallocatedworkitem_preallocatedworkitem_1246050329.md) overload.

## -examples

## -see-also
[PreallocatedWorkItem(WorkItemHandler)](preallocatedworkitem_preallocatedworkitem_1246050329.md), [PreallocatedWorkItem(WorkItemHandler, WorkItemPriority)](preallocatedworkitem_preallocatedworkitem_1267034869.md)