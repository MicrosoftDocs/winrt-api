---
-api-id: P:Windows.Devices.PointOfService.LineDisplayAttributes.BlinkRate
-api-type: winrt property
---

<!-- Property syntax.
public TimeSpan BlinkRate { get;  set; }
-->

# Windows.Devices.PointOfService.LineDisplayAttributes.BlinkRate

## -description
Gets or sets the blink rate of the line display.

## -property-value
The blink rate in milliseconds.

## -remarks
When the device supports blinking ([LineDisplayCapabilities.CanBlink](LineDisplayCapabilities_CanBlink.md) is not NotSupported) this writeable property configures the current blink cycle time. A blink cycle is the period of time when text completes an on-off-on cycle during blinking. After this property is set, the device driver (the Service Object) typically sets the blink rate to the closest supported rate.

When the device does not support blinking ([LineDisplayCapabilities.CanBlink](LineDisplayCapabilities_CanBlink.md) is NotSupported) this property is fixed to a value of 0 and cannot be changed.

The default value of this property is 0.

Changes to this property are committed to the device on the next call of [ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md).

## -see-also
[ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md)

## -examples

