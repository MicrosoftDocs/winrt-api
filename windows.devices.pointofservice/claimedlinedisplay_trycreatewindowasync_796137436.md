---
-api-id: M:Windows.Devices.PointOfService.ClaimedLineDisplay.TryCreateWindowAsync(Windows.Foundation.Rect,Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<LineDisplayWindow> ClaimedLineDisplay.TryCreateWindowAsync(Rect viewport, Size windowSize)
-->

# Windows.Devices.PointOfService.ClaimedLineDisplay.TryCreateWindowAsync

## -description
Attempts to asynchronously create a [LineDisplayWindow](linedisplaywindow.md).

## -parameters
### -param viewport
The viewport’s origin device row, origin device column, width in rows and height in columns.

### -param windowSize
The numbers of rows and the number of columns in the window.

## -returns
A new [LineDisplayWindow](linedisplaywindow.md) object, representing a new window for the device.

## -remarks
When [LineDisplayCapabiliaties.SupportedWindows](LineDisplayCapabiliaties_SupportedWindows.md) is greater than 0 this method can be called to create a new [LineDisplayWindow](linedisplaywindow.md) object representing a new window for the device. The new window is not automatically set as the current window when it is created, to set that window as current set the [LineDisplayAttributes.CurrentWindow](LineDisplayAttributes_CurrentWindow.md) property to point to this [LineDisplayWindow](linedisplaywindow.md) object, or on that same [LineDisplayWindow](linedisplaywindow.md) object call its [TryRefreshAsync](linedisplaywindow_tryrefreshasync_1864090804.md) method.

Calling this method when [LineDisplayCapabiliaties.SupportedWindows](LineDisplayCapabilities_SupportedWindows.md) is 0 will result in an exception.

The window size must be at least as large as the viewport size, and it may be larger than its viewport in at most one direction. When [LineDisplayCapabilities.IsVerticalMarqueeSupported](LineDisplayCapabilities_IsVerticalMarqueeSupported.md) is True, the window may be larger than the viewport in the vertical dimension. When [LineDisplayCapabilities.IsHorizontalMarqueeSupported](LineDisplayCapabilities_IsHorizontalMarqueeSupported.md) is True, the window may be larger than the viewport in the horizontal dimension.

## -see-also

## -examples

