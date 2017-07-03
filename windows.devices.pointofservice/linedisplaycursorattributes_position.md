---
-api-id: P:Windows.Devices.PointOfService.LineDisplayCursorAttributes.Position
-api-type: winrt property
---

<!-- Property syntax.
public Point Position { get;  set; }
-->

# Windows.Devices.PointOfService.LineDisplayCursorAttributes.Position

## -description
Gets or sets the position of the cursor.

## -property-value
The position of the cursor.

## -remarks
The maximum cursor position is described by the cursor owner’s LineDisplayWindow.Size property. 

The default value of this property is {0,0}.

Changes to this property are committed to the device on the next call to [LineDisplayCursor.TryUpdateAttributesAsync(LineDisplayCursorAttributes)](linedisplaycursor_tryupdateattributesasync_248842415.md).

## -see-also
[LineDisplayCursor.TryUpdateAttributesAsync(LineDisplayCursorAttributes)](linedisplaycursor_tryupdateattributesasync_248842415.md)

## -examples

