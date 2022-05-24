---
-api-id: P:Windows.Devices.PointOfService.LineDisplayAttributes.IsCharacterSetMappingEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsCharacterSetMappingEnabled { get;  set; }
-->

# Windows.Devices.PointOfService.LineDisplayAttributes.IsCharacterSetMappingEnabled

## -description
Gets or sets whether character set mapping is enabled.

## -property-value
True if character set mapping is enabled; otherwise, False.

## -remarks
When [LineDisplayCapabilities.CanMapCharacterSets](linedisplaycapabilities_canmapcharactersets.md) is True, this writeable property controls whether character mapping is enabled. When character mapping is enabled, characters sent by the application are mapped by the device driver/the Service Object to the characters supported by the device.

When [LineDisplayCapabilities.CanMapCharacterSets](linedisplaycapabilities_canmapcharactersets.md) is False the value of this property is fixed to False and cannot be changed.

Changes to this property are committed to the device on the next call to [ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md).

## -see-also
[ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md)

## -examples

