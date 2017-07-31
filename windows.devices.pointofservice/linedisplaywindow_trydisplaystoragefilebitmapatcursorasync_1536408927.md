---
-api-id: M:Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStorageFileBitmapAtCursorAsync(Windows.Storage.StorageFile,Windows.Devices.PointOfService.LineDisplayHorizontalAlignment,Windows.Devices.PointOfService.LineDisplayVerticalAlignment)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> LineDisplayWindow.TryDisplayStorageFileBitmapAtCursorAsync(StorageFile bitmap, LineDisplayHorizontalAlignment horizontalAlignment, LineDisplayVerticalAlignment verticalAlignment)
-->

# Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStorageFileBitmapAtCursorAsync

## -description
Attempts to asynchronously display a bitmap from a storage file at the current cursor position.

## -parameters
### -param bitmap
The bitmap to be displayed.

### -param horizontalAlignment
The horizontal alignment of the bitmap relative to the current text character position.

### -param verticalAlignment
The vertical alignment of the bitmap relative to the current text character position.

## -returns
Return True if the bitmap was successfully displayed; otherwise, False. 

## -remarks
If the [LineDisplayCapabilities.CanDisplayBitmaps](linedisplaycapabilities_candisplaybitmaps.md) value is False, this method will fail.

## -see-also

## -examples

