---
-api-id: M:Windows.Devices.Display.Core.DisplayDevice.CreateSimpleScanoutWithDirtyRectsAndOptions(Windows.Devices.Display.Core.DisplaySource,Windows.Devices.Display.Core.DisplaySurface,System.UInt32,System.UInt32,Windows.Foundation.Collections.IIterable{Windows.Graphics.RectInt32},Windows.Devices.Display.Core.DisplayScanoutOptions)
-api-type: winrt method
---

# Windows.Devices.Display.Core.DisplayDevice.CreateSimpleScanoutWithDirtyRectsAndOptions(Windows.Devices.Display.Core.DisplaySource,Windows.Devices.Display.Core.DisplaySurface,System.UInt32,System.UInt32,Windows.Foundation.Collections.IIterable{Windows.Graphics.RectInt32},Windows.Devices.Display.Core.DisplayScanoutOptions)

<!--
public Windows.Devices.Display.Core.DisplayScanout CreateSimpleScanoutWithDirtyRectsAndOptions (Windows.Devices.Display.Core.DisplaySource source, Windows.Devices.Display.Core.DisplaySurface surface, uint subresourceIndex, uint syncInterval, System.Collections.Generic.IEnumerable<Windows.Graphics.RectInt32> dirtyRects, Windows.Devices.Display.Core.DisplayScanoutOptions options);
-->

## -description

Creates a [DisplayScanout](displayscanout.md) object that provides an immutable encapsulation of parameters required for presenting a frame to a [DisplaySource](displaysource.md).

## -parameters

### -param source
A [DisplaySource](displaysource.md) to present content to.

### -param surface
A primary surface.

### -param subresourceIndex

Related to Direct3D's concept of [subresources](/windows/win32/direct3d11/overviews-direct3d-11-resources-subresources). Using this index, you can specify which subresource within the [DisplaySurface](displaysurface.md) should be used for scanout, in the event that there are multiple subresources.

The only way to have a **DisplaySurface** that has multiple subresources is either to create the **DisplaySurface** with the *isStereo* flag (see [CreateWithProperties](/uwp/api/windows.devices.display.core.displayprimarydescription.createwithproperties)), or to open an [ID3D11Texture2D](/windows/win32/api/d3d11/nn-d3d11-id3d11texture2d) using APIs in [IDisplayDeviceInterop](/windows/win32/api/windows.devices.display.core.interop/nn-windows-devices-display-core-interop-idisplaydeviceinterop).

The most common value for *subresourceindex* will be 0, which indicates that no subresource is needed or available.

### -param syncInterval

An integer that specifies how to synchronize presentation of a frame with the vertical blank of the display.

*SyncInterval* == 0. Presentation happens on the next vertical blank from the display. If there are other presents in the queue with value = 0, then those presents are discarded.
*SyncInterval* == 0, with [DisplayScanoutOptions::AllowTearing](displayscanoutoptions.md). The presentation occurs immediately; there is no synchronization with the previous frame. This can cause visible tearing.
*SyncInterval* == 1 through 4. Synchronize presentation for at least *n* vertical blanks of the display.

### -param dirtyRects

Dirty rectangles that provide a hint to the graphics driver indicating which regions of the primary are changing. This might be used by the driver to reduce the amount of bandwidth on the underlying display transport, so you must pass valid rectangles that fully encompass all changed pixels in a frame.

This is an optimization, and if your DirectDisplay client doesn't track dirty rectangles, then you can pass `null` for *dirtyRects*, and the operating system will consider that as a full-frame dirty (meaning that all the pixels in the primary buffer are modified). If you pass an empty list for *dirtyRects* then that means that no pixels have been changed in the primary buffer, and the graphics driver might choose to optimize the scanout of this primary buffer.

### -param options

Flags that can specify various options for the [DisplayScanout](displayscanout.md) being created. [DisplayScanoutOptions.AllowTearing](displayscanoutoptions.md) is valid only if *syncInterval* is 0.

## -returns
A [DisplayScanout](displayscanout.md) value.

## -remarks

## -see-also

## -examples
