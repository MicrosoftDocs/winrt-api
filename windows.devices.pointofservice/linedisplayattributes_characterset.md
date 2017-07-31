---
-api-id: P:Windows.Devices.PointOfService.LineDisplayAttributes.CharacterSet
-api-type: winrt property
---

<!-- Property syntax.
public int CharacterSet { get;  set; }
-->

# Windows.Devices.PointOfService.LineDisplayAttributes.CharacterSet

## -description
Gets or sets the current character set used by the device to display characters.

## -property-value
The current character set.

## -remarks
Valid values for this property are the values stored in [ClaimedLineDisplay.SupportedCharacterSets](ClaimedLineDisplay_SupportedCharacterSets.md).

Changes to this property are committed to the device on the next call to [ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md).

## -see-also
[ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md)

## -examples

