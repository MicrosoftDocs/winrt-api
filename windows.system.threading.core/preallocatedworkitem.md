---
-api-id: T:Windows.System.Threading.Core.PreallocatedWorkItem
-api-type: winrt class
---

<!-- Class syntax.
public class PreallocatedWorkItem : Windows.System.Threading.Core.IPreallocatedWorkItem
-->

# Windows.System.Threading.Core.PreallocatedWorkItem

## -description
A preallocated work item is constructed in advance of its submission to the thread pool, ensuring that the work item is constructed so that it can be submitted to the thread pool when necessary. For example, a [PreallocatedWorkItem](preallocatedworkitem.md) can be created in case it is needed for a resource deallocation routine, since the resource deallocation routine may be called in circumstances when not enough resources would be available to create the work item.

> [!NOTE]
> The ThreadPool API is supported for desktop as well as UWP apps.

## -remarks

## -examples

## -see-also
