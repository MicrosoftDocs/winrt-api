---
-api-id: P:Windows.Devices.Display.Core.DisplayTaskResult.PresentId
-api-type: winrt property
---

# Windows.Devices.Display.Core.DisplayTaskResult.PresentId

<!--
public ulong PresentId { get; }
-->

## -description

Gets a value representing the number of presents that have been requested on a given [DisplayTaskPool](displaytaskpool.md).

## -property-value

A UINT64 type identifier representing the number of presents that have been requested on a given [DisplayTaskPool](displaytaskpool.md).

## -remarks

The value returned increments monotonically by 1 on every call to [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md) for a given [DisplayTaskPool](displaytaskpool.md), irrespective of whether the **TryExecuteTask** returned [DisplayPresentStatus.Succeeded](displaypresentstatus.md) in [DisplayTaskResult.PresentStatus](displaytaskresult_presentstatus.md).

The only scenario where **PresentId** won't be incremented is where you call **TryExecuteTask** with invalid parameters, and DirectDisplay runtime validation fails before it calls into the kernel. In those cases, **TryExecuteTask** will fail right away, and return an HRESULT. For a new [DisplayTaskPool](displaytaskpool.md) object, **PresentId** will be reset to 0, and the very first **TryExecuteTask** will return a **PresentId** equal to 1.

One of the common usages of **PresentId** is that you can use it to put a wait on a fence used as an input to [DisplayTask.SetSignal](displaytask_setsignal_711490548.md).

## -see-also
[DisplayTaskPool](displaytaskpool.md), [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md), [DisplayPresentStatus](displaypresentstatus.md), [DisplayTaskResult.PresentStatus](displaytaskresult_presentstatus.md), [DisplayTask.SetSignal](displaytask_setsignal_711490548.md)

## -examples
