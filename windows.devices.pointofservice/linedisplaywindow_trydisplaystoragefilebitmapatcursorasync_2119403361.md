---
-api-id: M:Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStorageFileBitmapAtCursorAsync(Windows.Storage.StorageFile,Windows.Devices.PointOfService.LineDisplayHorizontalAlignment,Windows.Devices.PointOfService.LineDisplayVerticalAlignment,System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> LineDisplayWindow.TryDisplayStorageFileBitmapAtCursorAsync(StorageFile bitmap, LineDisplayHorizontalAlignment horizontalAlignment, LineDisplayVerticalAlignment verticalAlignment, Int32 widthInPixels)
-->

# Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStorageFileBitmapAtCursorAsync

## -description
Attempts to asynchronously display a bitmap from a storage file at the current cursor position, at a particular width.

## -parameters
### -param bitmap
The bitmap to be displayed.

### -param horizontalAlignment
The horizontal alignment of the bitmap relative to the current text character position.

### -param verticalAlignment
The vertical alignment of the bitmap relative to the current text character position.

### -param widthInPixels
The desired width of the bitmap. A value of 0 pixels will display the bitmap at one pixel per screen dot (unscaled).

## -returns
Return True if the bitmap was successfully displayed; otherwise, False. 

## -remarks
If the [LineDisplayCapabilities.CanDisplayBitmaps](linedisplaycapabilities_candisplaybitmaps.md) value is False, this method will fail.

If the provided widthInPixels value is larger than [ClaimedLineDisplay.MaxBitmapSizeInPixels](claimedlinedisplay_maxbitmapsizeinpixels.md), this method will fail.

## -see-also

## -examples

