---
-api-id: M:Windows.Devices.Display.Core.DisplayDevice.CreatePrimary(Windows.Devices.Display.Core.DisplayTarget,Windows.Devices.Display.Core.DisplayPrimaryDescription)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public DisplaySurface DisplayDevice.CreatePrimary(DisplayTarget target, DisplayPrimaryDescription desc)
-->

# Windows.Devices.Display.Core.DisplayDevice.CreatePrimary

## -description
Creates a primary surface (or just "primary") for use with the display controller. The resulting primary surface is compatible with a [DisplayScanout](displayscanout.md), which is used for presenting content directly to the screen.

## -parameters
### -param target
An active [DisplayTarget](displaytarget.md), which is used to determine which source the primary will be optimized for.

### -param desc
A description of the primary surface to create, such as width, height, and pixel format.

## -returns
A [DisplaySurface](displaysurface.md) value.

## -remarks
A primary surface is usually optimized by display hardware for scanout on only a single [DisplaySource](displaysource.md), so the [DisplayTarget](displaytarget.md) used to create the primary should also be the one used to create the DisplaySource and [DisplayScanout](displayscanout.md) objects. Otherwise, presentation of the surface or creation of the [DisplayScanout](displayscanout.md) may fail.

## -see-also

## -examples
