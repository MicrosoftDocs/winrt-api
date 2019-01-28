---
-api-id: M:Windows.Devices.Display.Core.DisplayDevice.WaitForVBlank(Windows.Devices.Display.Core.DisplaySource)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void DisplayDevice.WaitForVBlank(DisplaySource source)
-->

# Windows.Devices.Display.Core.DisplayDevice.WaitForVBlank

## -description
Synchronously waits for the next V-blank interrupt to be fired by the primary [DisplayTarget](displaytarget.md) for a given [DisplaySource](displaysource.md).

## -parameters
### -param source
The [DisplaySource](displaysource.md) whose primary display target's V-blank interrupt to wait for.

## -remarks
In hardware clone scenarios, a display source may be connected to multiple display targets. In these situations, this method waits for the next V-blank on the display target connected via the primary path of the [DisplayView](displayview.md).

## -see-also

## -examples
