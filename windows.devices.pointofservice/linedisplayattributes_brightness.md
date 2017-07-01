---
-api-id: P:Windows.Devices.PointOfService.LineDisplayAttributes.Brightness
-api-type: winrt property
---

<!-- Property syntax.
public int Brightness { get;  set; }
-->

# Windows.Devices.PointOfService.LineDisplayAttributes.Brightness

## -description
Gets or sets the brightness of the line display.

## -property-value
The brightness of the line display.

## -remarks
When the device supports brightness adjustment ([LineDisplayCapabilities.IsBrightnessSupported](LineDisplayCapabilities_IsBrightnessSupported.md) is True) this writeable property configures the current screen brightness, in percent (valid values are positive integers from 0 to 100, inclusive). All devices support 100% (maximum brightness) and 0% (blank screen). Some devices also support dimming values in between these limits. In all cases the device driver (the Service Object) maps the requested brightness value to the closest value supported by the Hardware device. 

The default value of this property is 100.

Changes to this property are committed to the device on the next call to [ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md).

## -see-also
[ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md)

## -examples

