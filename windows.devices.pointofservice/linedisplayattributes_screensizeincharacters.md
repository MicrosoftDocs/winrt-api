---
-api-id: P:Windows.Devices.PointOfService.LineDisplayAttributes.ScreenSizeInCharacters
-api-type: winrt property
---

<!-- Property syntax.
public Size ScreenSizeInCharacters { get;  set; }
-->

# Windows.Devices.PointOfService.LineDisplayAttributes.ScreenSizeInCharacters

## -description
Gets or sets the current screen size.

## -property-value
The current screen size in characters.

## -remarks
When the device supports multiple screen sizes ([LineDisplayCapabilities.CanChangeScreenSize](linedisplaycapabilities_canchangescreensize.md) is True) this writeable property configures the current screen size. When bitmaps are also supported, changing the ScreenSizeinCharacters property may cause MaxBitmapSize to change to a new value.

When the device supports only one screen size ([LineDisplayCapabilities.CanChangeScreenSize](linedisplaycapabilities_canchangescreensize.md) is False) this property supports only one value, behaving as a read-only property.

Changes to this property are committed to the device on the next call to [ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md).

## -see-also
[ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md)

## -examples

