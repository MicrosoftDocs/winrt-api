---
-api-id: T:Windows.Devices.Display.Core.DisplayTarget
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class DisplayTarget 
-->

# Windows.Devices.Display.Core.DisplayTarget

## -description
Represents a slice in time of a logical "target" for the display pipeline. This is typically analogous to a physical connector on a GPU, such as an HDMI port, but it can be a virtual target representing daisy-chained DisplayPort targets.

## -remarks
A **DisplayTarget** object is immutable, except for the [IsStale](displaytarget_isstale.md) property. If **IsStale** is `true`, then you can re-enumerate the latest state for all **DisplayTarget** objects by calling [DisplayManager.GetCurrentTargets](displaymanager_getcurrenttargets_1359061908.md).

## -see-also

## -examples
