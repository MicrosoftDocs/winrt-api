---
-api-id: P:Windows.Devices.PointOfService.LineDisplayAttributes.CurrentWindow
-api-type: winrt property
---

<!-- Property syntax.
public LineDisplayWindow CurrentWindow { get;  set; }
-->

# Windows.Devices.PointOfService.LineDisplayAttributes.CurrentWindow

## -description
Gets or sets the current window to which text is displayed.

## -property-value
The current window to which text is displayed.

## -remarks
Setting the current window does not refresh that window's viewport. If the viewports of the current window and another window overlap, and the other window has changed content within the viewport, then refreshWindow may be called to restore the window's viewport contents.

Changes to this property are committed to the device on the next call to [ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md).

## -see-also
[ClaimedLineDisplay.TryUpdateAttributesAsync(LineDisplayAttributes)](claimedlinedisplay_tryupdateattributesasync_1303674463.md)

## -examples

