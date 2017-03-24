---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.PenTipTransform
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Numerics.Matrix3x2 PenTipTransform { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.PenTipTransform

## -description
Gets or sets an affine transformation matrix applied to the [PenTipShape](pentipshape.md) used for an [InkStroke](inkstroke.md).

## -property-value
The 2-D affine transformation matrix. The default is the identity matrix.

## -remarks
The M31 and M32 entries of the matrix must be zero.

This property enables various calligraphic effects, depending on [PenTip](inkdrawingattributes_pentip.md) and [PenTipShape](pentipshape.md).

## -examples

## -see-also
[PenTip](inkdrawingattributes_pentip.md), [PenTipShape](pentipshape.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)