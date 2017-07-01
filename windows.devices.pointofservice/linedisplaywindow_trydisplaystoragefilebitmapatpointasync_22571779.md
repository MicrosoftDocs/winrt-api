---
-api-id: M:Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStorageFileBitmapAtPointAsync(Windows.Storage.StorageFile,Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> LineDisplayWindow.TryDisplayStorageFileBitmapAtPointAsync(StorageFile bitmap, Point offsetInPixels)
-->

# Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStorageFileBitmapAtPointAsync

## -description
Attempts to asynchronously display a bitmap from a storage file at a particular point.

## -parameters
### -param bitmap
The bitmap to be displayed.

### -param offsetInPixels
The number of pixels to offset the bitmap display from the top-left corner of the screen, {0,0}.

## -returns
Return True if the bitmap was successfully displayed; otherwise, False. 

## -remarks
If the [LineDisplayCapabilities.CanDisplayBitmaps](linedisplaycapabilities_candisplaybitmaps.md) value is False, this method will fail.

## -see-also

## -examples

