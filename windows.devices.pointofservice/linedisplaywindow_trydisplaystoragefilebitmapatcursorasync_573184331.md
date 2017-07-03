---
-api-id: M:Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStorageFileBitmapAtCursorAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> LineDisplayWindow.TryDisplayStorageFileBitmapAtCursorAsync(StorageFile bitmap)
-->

# Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStorageFileBitmapAtCursorAsync

## -description
Attempts to asynchronously display a bitmap from a storage file at the current cursor position.

## -parameters
### -param bitmap
The bitmap to be displayed.

## -returns
Return True if the bitmap was successfully displayed; otherwise, False. 

## -remarks
If the [LineDisplayCapabilities.CanDisplayBitmaps](linedisplaycapabilities_candisplaybitmaps.md) value is False, this method will fail.

## -see-also

## -examples

