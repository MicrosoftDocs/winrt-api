---
-api-id: T:Windows.UI.Text.PointOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.PointOptions : uint
-->

# PointOptions

## -description
Defines options for specifying or retrieving a point.

## -enum-fields
### -field None:0
No options.

### -field IncludeInset:1
Add left and top insets to the left and top coordinates of the rectangle, and subtract right and bottom insets from the right and bottom coordinates.

### -field Start:32
The start position of the text range.

### -field ClientCoordinates:256
Return client coordinates instead of screen coordinates.

### -field AllowOffClient:512
Allow points outside of the client area.

### -field Transform:1024
Transform coordinates using a world transform supplied by the host app.

### -field NoHorizontalScroll:65536
Horizontal scrolling is disabled.

### -field NoVerticalScroll:262144
Vertical scrolling is disabled.


## -remarks

## -examples

## -see-also
[ITextDocument.GetRangeFromPoint](itextdocument_getrangefrompoint.md), [ITextRange.GetPoint](itextrange_getpoint.md), [ITextRange.GetRect](itextrange_getrect.md), [ITextRange.ScrollIntoView](itextrange_scrollintoview.md), [ITextRange.SetPoint](itextrange_setpoint.md)