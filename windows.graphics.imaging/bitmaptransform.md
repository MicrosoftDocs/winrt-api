---
-api-id: T:Windows.Graphics.Imaging.BitmapTransform
-api-type: winrt class
---

<!-- Class syntax.
public class BitmapTransform : Windows.Graphics.Imaging.IBitmapTransform
-->

# Windows.Graphics.Imaging.BitmapTransform

## -description
Contains transformations that can be applied to pixel data.

## -remarks
The default values of BitmapTransform result in a pass-through operation.

The order of operations is when setting multiple transform operations is:


1. Scale
1. Flip
1. Rotation
1. Crop
You should be careful to use the correct coordinate space when specifying each transform’s parameters. Scaling occurs before rotations and flips, and therefore you should specify [ScaledWidth](bitmaptransform_scaledwidth.md) and [ScaledHeight](bitmaptransform_scaledheight.md) in the source image’s coordinate space. Cropping occurs after all other transforms, and therefore you should specify [Bounds](bitmaptransform_bounds.md) in the final scaled/flipped/rotated coordinate space.

If you are using BitmapTransform with a method that performs EXIF orientation, such as [GetPixelDataAsync](bitmapframe_getpixeldataasync_1391309547.md), note that the EXIF orientation operation is combined with the flip/rotate stage. In these cases the behavior of [ScaledWidth](bitmaptransform_scaledwidth.md) and [ScaledHeight](bitmaptransform_scaledheight.md) are not affected as scaling occurs before flip/rotate. However, when specifying [Bounds](bitmaptransform_bounds.md) you need to account for coordinate space changes from [Flip](bitmaptransform_flip.md) and [Rotation](bitmaptransform_rotation.md), as well as the EXIF orientation operation. You can obtain the full image size after EXIF orientation is applied by using [OrientedPixelWidth](bitmapframe_orientedpixelwidth.md) and [OrientedPixelHeight](bitmapframe_orientedpixelheight.md).

## -examples

## -see-also
