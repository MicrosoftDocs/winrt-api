---
-api-id: M:Windows.Devices.Display.Core.DisplayTask.SetWait(Windows.Devices.Display.Core.DisplayFence,System.UInt64)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void DisplayTask.SetWait(DisplayFence readyFence, UInt64 readyFenceValue)
-->

# Windows.Devices.Display.Core.DisplayTask.SetWait

## -description
Sets the operations for this [DisplayTask](displaytask.md) to occur once the specified GPU fence is signaled with the specified value.

## -parameters
### -param readyFence
A [DisplayFence](displayfence.md) object representing the GPU fence to wait on before performing this task's operations.

### -param readyFenceValue
The value of the GPU fence to wait on.

## -remarks

## -see-also

## -examples
