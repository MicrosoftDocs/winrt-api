---
-api-id: M:Windows.Devices.Display.Core.DisplayTaskPool.TryExecuteTask(Windows.Devices.Display.Core.DisplayTask)
-api-type: winrt method
---

# Windows.Devices.Display.Core.DisplayTaskPool.TryExecuteTask(Windows.Devices.Display.Core.DisplayTask)

<!--
public Windows.Devices.Display.Core.DisplayTaskResult TryExecuteTask (Windows.Devices.Display.Core.DisplayTask task);
-->

## -description

Queues a [DisplayTask](displaytask.md) for execution on the device. Tasks are executed asynchronously, so this method returns immediately. **TryExecuteTask** provides a [DisplayTaskResult](displaytaskresult.md) object, which affords you multiple pieces of feedback/info regarding the state of the presentation request.

## -parameters

### -param task

The [DisplayTask](displaytask.md) to queue.

## -returns

A [DisplayTaskResult](displaytaskresult.md) object, providing simple actionable feedback about what happened, and what you should do about it.

## -remarks

## -see-also

## -examples
