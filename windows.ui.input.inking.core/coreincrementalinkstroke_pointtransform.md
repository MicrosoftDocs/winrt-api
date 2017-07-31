---
-api-id: P:Windows.UI.Input.Inking.Core.CoreIncrementalInkStroke.PointTransform
-api-type: winrt property
---

<!-- Property syntax.
public Matrix3x2 PointTransform { get; }
-->

# Windows.UI.Input.Inking.Core.CoreIncrementalInkStroke.PointTransform

## -description
Gets or sets an affine transformation matrix to apply to the [**CoreIncrementalInkStroke**](coreincrementalinkstroke.md) object.

Both position and rotation are based on the top left corner of the stroke relative to the origin of the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

## -property-value
The position and angle of the stroke as a 3*2 floating point matrix.

The default position is the origin of the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md). The default rotation angle is 0 degrees.

## -remarks

## -see-also

## -examples

