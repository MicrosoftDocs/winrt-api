---
-api-id: P:Windows.UI.Composition.CompositionClip.RotationAngle
-api-type: winrt property
---

<!-- Property syntax
public float RotationAngle { get;  set; }
-->

# Windows.UI.Composition.CompositionClip.RotationAngle

## -description
The angle of rotation applied to the clip, in radians.



## -property-value
The angle of rotation applied to the clip, in radians. For a [CompositionClip](compositionclip.md), the axis of rotation is always about the z-axis, with positive RotationAngle values resulting in a clockwise rotation and negative values resulting in a counter-clockwise rotation. For specifying RotationAngle in degrees, use [CompositionClip.RotationAngleInDegrees](compositionclip_rotationangleindegrees.md). If both RotationAngle and [CompositionClip.RotationAngleInDegrees](compositionclip_rotationangleindegrees.md) are set on the same [CompositionClip](compositionclip.md) object, whichever value is set last will override the other value.

By default, the RotationAngle value on a clip is (0, 0).

## -remarks

## -examples

## -see-also
[CompositionClip.RotationAngleInDegrees](compositionclip_rotationangleindegrees.md), [Visual.RotationAngle](visual_rotationangle.md)
