---
-api-id: M:Windows.Devices.Display.Core.DisplayTaskPool.ExecuteTask(Windows.Devices.Display.Core.DisplayTask)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void DisplayTaskPool.ExecuteTask(DisplayTask task)
-->

# Windows.Devices.Display.Core.DisplayTaskPool.ExecuteTask

## -description

Queues a [DisplayTask](displaytask.md) for execution on the device. Tasks are executed asynchronously, so this method returns immediately.

> [!NOTE]
> **ExecuteTask** is deprecated in favor of [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md), which provides feedback about the state of the presentation request.

## -parameters
### -param task

The [DisplayTask](displaytask.md) to queue.

## -remarks

## -see-also
[DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md)

## -examples
