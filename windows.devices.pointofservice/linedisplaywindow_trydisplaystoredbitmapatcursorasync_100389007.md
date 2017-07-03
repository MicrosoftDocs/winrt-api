---
-api-id: M:Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStoredBitmapAtCursorAsync(Windows.Devices.PointOfService.LineDisplayStoredBitmap)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> LineDisplayWindow.TryDisplayStoredBitmapAtCursorAsync(LineDisplayStoredBitmap bitmap)
-->

# Windows.Devices.PointOfService.LineDisplayWindow.TryDisplayStoredBitmapAtCursorAsync

## -description
Attempts to asynchronously display a stored bitmap from at LineDisplayStoredBitmap object at the current cursor position.

## -parameters
### -param bitmap
The bitmap to be displayed.

## -returns
Returns True if the bitmap was successfully displayed; otherwise, False.

## -remarks
If the [LineDisplayCapabilities.CanDisplayBitmaps](linedisplaycapabilities_candisplaybitmaps.md) value is False, this method will fail.

## -see-also

## -examples

