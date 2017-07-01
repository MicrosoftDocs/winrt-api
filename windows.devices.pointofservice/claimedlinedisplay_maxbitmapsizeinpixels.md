---
-api-id: P:Windows.Devices.PointOfService.ClaimedLineDisplay.MaxBitmapSizeInPixels
-api-type: winrt property
---

<!-- Property syntax.
public Size MaxBitmapSizeInPixels { get; }
-->

# Windows.Devices.PointOfService.ClaimedLineDisplay.MaxBitmapSizeInPixels

## -description
Gets the maximum bitmap size.

## -property-value
The maximum bitmap size in pixels.

## -remarks
When bitmaps are supported (when [LineDisplayCapabilities.CanDisplayBitmaps](LineDisplayCapabilities_CanDisplayBitmaps.md) is True) this read-only property describes the size of the screen that can display bitmaps as number of horizontal and vertical pixels. The maximum number of pixels in each direction is 65,535. When bitmaps are not supported by the device ([LineDisplayCapabilities.CanDisplayBitmaps](LineDisplayCapabilities_CanDisplayBitmaps.md) is False) the value of this property is {0, 0}. 

## -see-also

## -examples

