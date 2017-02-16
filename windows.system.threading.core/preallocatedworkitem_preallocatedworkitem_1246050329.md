---
-api-id: M:Windows.System.Threading.Core.PreallocatedWorkItem.#ctor(Windows.System.Threading.WorkItemHandler)
-api-type: winrt method
---

<!-- Method syntax
public PreallocatedWorkItem(Windows.System.Threading.WorkItemHandler handler)
-->

# Windows.System.Threading.Core.PreallocatedWorkItem.PreallocatedWorkItem

## -description
Initializes a new work item with a [WorkItemHandler](../windows.system.threading/workitemhandler.md) delegate, allocating resources for the work item in advance.

## -parameters
### -param handler
Indicates the method that the preallocated work item will run.

## -remarks
In C++, make sure that methods used as [WorkItemHandler](../windows.system.threading/workitemhandler.md) delegates exhibit agile threading model behavior. Calling a non-agile method from a work item will cause a deadlock to occur.

## -examples

## -see-also
[WorkItemHandler](../windows.system.threading/workitemhandler.md), [PreallocatedWorkItem(WorkItemHandler, WorkItemPriority)](preallocatedworkitem_preallocatedworkitem_1267034869.md), [PreallocatedWorkItem(WorkItemHandler, WorkItemPriority, WorkItemOptions)](preallocatedworkitem_preallocatedworkitem_1249717629.md)