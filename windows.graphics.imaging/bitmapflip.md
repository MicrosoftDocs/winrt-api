---
-api-id: T:Windows.Graphics.Imaging.BitmapFlip
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.Imaging.BitmapFlip : int
-->

# BitmapFlip

## -description
Specifies the flip operation to be performed on pixel data.

## -enum-fields
### -field None:0
No flip operation will be performed.

### -field Horizontal:1
Flip the bitmap around the y axis.

### -field Vertical:2
Flip the bitmap around the x axis.


## -remarks
This enumeration is used when setting the [Flip](bitmaptransform_flip.md) property of a [BitmapTransform](bitmaptransform.md).

## -examples

## -see-also
[BitmapTransform](bitmaptransform.md)