---
-api-id: M:Windows.System.Threading.Core.PreallocatedWorkItem.#ctor(Windows.System.Threading.WorkItemHandler,Windows.System.Threading.WorkItemPriority)
-api-type: winrt method
---

<!-- Method syntax
public PreallocatedWorkItem(Windows.System.Threading.WorkItemHandler handler, Windows.System.Threading.WorkItemPriority priority)
-->

# Windows.System.Threading.Core.PreallocatedWorkItem.PreallocatedWorkItem

## -description
Initializes a new work item with a [WorkItemHandler](../windows.system.threading/workitemhandler.md) delegate, allocating resources for the work item in advance, and specifies the priority of the work item relative to other work items in the thread pool.

## -parameters
### -param handler
Indicates the method that the preallocated work item will run.

### -param priority
The priority of the work item relative to other work items in the thread pool. The value of this parameter can be **Low**, **Normal**, or **High**.

## -remarks
See the remarks section of the [PreallocatedWorkItem(WorkItemHandler)](preallocatedworkitem_preallocatedworkitem_1246050329.md) overload.

## -examples

## -see-also
[PreallocatedWorkItem(WorkItemHandler)](preallocatedworkitem_preallocatedworkitem_1246050329.md), [PreallocatedWorkItem(WorkItemHandler, WorkItemPriority, WorkItemOptions)](preallocatedworkitem_preallocatedworkitem_1249717629.md)