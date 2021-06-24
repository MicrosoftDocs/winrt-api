---
-api-id: M:Windows.Devices.Display.Core.DisplayDevice.CreateSimpleScanout(Windows.Devices.Display.Core.DisplaySource,Windows.Devices.Display.Core.DisplaySurface,System.UInt32,System.UInt32)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public DisplayScanout DisplayDevice.CreateSimpleScanout(DisplaySource pSource, DisplaySurface pSurface, UInt32 SubResourceIndex, UInt32 SyncInterval)
-->

# Windows.Devices.Display.Core.DisplayDevice.CreateSimpleScanout

## -description
Creates a [DisplayScanout](displayscanout.md) object that can be used to present a full-screen surface directly to the screen.

## -parameters
### -param pSource
A [DisplaySource](displaysource.md) to present full-screen content to.

### -param pSurface
A full-screen primary surface.

### -param SubResourceIndex

Related to Direct3D's concept of [subresources](/windows/win32/direct3d11/overviews-direct3d-11-resources-subresources). Using this index, you can specify which subresource within the [DisplaySurface](displaysurface.md) should be used for scanout, in the event that there are multiple subresources.

The only way to have a **DisplaySurface** that has multiple subresources is either to create the **DisplaySurface** with the *isStereo* flag (see [CreateWithProperties](/uwp/api/windows.devices.display.core.displayprimarydescription.createwithproperties)), or to open an [ID3D11Texture2D](/windows/win32/api/d3d11/nn-d3d11-id3d11texture2d) using APIs in [IDisplayDeviceInterop](/windows/win32/api/windows.devices.display.core.interop/nn-windows-devices-display-core-interop-idisplaydeviceinterop).

The most common value for *subresourceindex* will be 0, which indicates that no subresource is needed or available.

### -param SyncInterval

An integer that specifies how to synchronize presentation of a frame with the vertical blank of the display.

*SyncInterval* == 0. Presentation happens on the next vertical blank from the display. If there are other presents in the queue with value = 0, then those presents are discarded.
*SyncInterval* == 0, with [DisplayScanoutOptions::AllowTearing](displayscanoutoptions.md). The presentation occurs immediately; there is no synchronization with the previous frame. This can cause visible tearing.
*SyncInterval* == 1 through 4. Synchronize presentation for at least *n* vertical blanks of the display.

## -returns
A [DisplayScanout](displayscanout.md) value.

## -remarks

## -see-also

## -examples
