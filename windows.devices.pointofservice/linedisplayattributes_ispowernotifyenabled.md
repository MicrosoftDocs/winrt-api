---
-api-id: P:Windows.Devices.PointOfService.LineDisplayAttributes.IsPowerNotifyEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsPowerNotifyEnabled { get;  set; }
-->

# Windows.Devices.PointOfService.LineDisplayAttributes.IsPowerNotifyEnabled

## -description
Gets or sets whether the device is enabled to notify the user of power state changes.

## -property-value
True if power state notifications are enabled; otherwise, False.

## -remarks
Power state notifications are delivered via [ClaimedLineDisplay.StatusUpdated](ClaimedLineDisplay_StatusUpdated.md). The property's default value is False (meaning that the device does not send power state notifications even if the app is subscribed to the [ClaimedLineDisplay.StatusUpdated](ClaimedLineDisplay_StatusUpdated.md) event). This property can be set to True only when [LineDisplayCapabilities.PowerReportingType](LineDisplayCapabilities_PowerReportingType.md) is not set to UnknownPowerReportingType. 

Changes to this property are committed to the device on the next call to [ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md).

## -see-also
[ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md)

## -examples

