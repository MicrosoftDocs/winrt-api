---
-api-id: P:Windows.Devices.PointOfService.LineDisplayCursorAttributes.IsAutoAdvanceEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsAutoAdvanceEnabled { get;  set; }
-->

# Windows.Devices.PointOfService.LineDisplayCursorAttributes.IsAutoAdvanceEnabled

## -description
Gets or sets whether automatic advancing of the cursor is enabled.

## -property-value
True if automatic advancing is enabled; otherwise, False.

## -remarks
When set to True, the cursor’s Position will be automatically updated to point to the next character to be displayed, whenever text is displayed. When False, the cursor position will not be automatically updated when characters are displayed.

Changes to this property are committed to the device on the next call to [LineDisplayCursor.TryUpdateAttributesAsync(LineDisplayCursorAttributes)](linedisplaycursor_tryupdateattributesasync_248842415.md).

## -see-also
[LineDisplayCursor.TryUpdateAttributesAsync(LineDisplayCursorAttributes)](linedisplaycursor_tryupdateattributesasync_248842415.md)

## -examples

