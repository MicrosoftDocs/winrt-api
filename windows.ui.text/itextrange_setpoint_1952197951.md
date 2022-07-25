---
-api-id: M:Windows.UI.Text.ITextRange.SetPoint(Windows.Foundation.Point,Windows.UI.Text.PointOptions,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void SetPoint(Windows.Foundation.Point point, Windows.UI.Text.PointOptions options, System.Boolean extend)
-->

# Windows.UI.Text.ITextRange.SetPoint

## -description
Changes the text range based on the specified point.



## -parameters
### -param point
An ordered pair of floating-point x- and y-coordinates that defines a point in a two-dimensional plane.

### -param options
The alignment type of the specified *point*.

### -param extend
Indicates how to set the endpoints of the text range. If *extend* is 0, the text range is an insertion point located at the specified point, or at the nearest point with selectable text. If *extend* is 1, the endpoint specified by *options* is moved to the *point* and the other endpoint is left alone. The default value is 0.

## -remarks

## -examples

## -see-also
[ITextRange.GetPoint](itextrange_getpoint_1487502073.md)
