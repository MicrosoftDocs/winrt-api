---
-api-id: M:Windows.Devices.Display.Core.DisplayDevice.CreatePeriodicFence(Windows.Devices.Display.Core.DisplayTarget,Windows.Foundation.TimeSpan)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public DisplayFence DisplayDevice.CreatePeriodicFence(DisplayTarget target, TimeSpan offsetFromVBlank)
-->

# Windows.Devices.Display.Core.DisplayDevice.CreatePeriodicFence

## -description
Creates a [DisplayFence](displayfence.md) object that is automatically signaled by the system with an incrementing value at a certain time every vertical refresh cycle.

## -parameters
### -param target
The [DisplayTarget](displaytarget.md) (which must be currently active) whose vertical refresh cycle will be used by the periodic fence.

### -param offsetFromVBlank
A time offset from the display controller's V-blank interrupt to signal the fence *before* every vertical refresh cycle.

## -returns
A [DisplayFence](displayfence.md) object.

## -remarks

## -see-also

## -examples
