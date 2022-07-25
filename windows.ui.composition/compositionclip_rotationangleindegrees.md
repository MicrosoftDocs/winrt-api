---
-api-id: P:Windows.UI.Composition.CompositionClip.RotationAngleInDegrees
-api-type: winrt property
---

<!-- Property syntax
public float RotationAngleInDegrees { get;  set; }
-->

# Windows.UI.Composition.CompositionClip.RotationAngleInDegrees

## -description
The angle of rotation applied to the clip, in degrees.



## -property-value
The angle of rotation applied to the clip, in degrees. For a [CompositionClip](compositionclip.md), the axis of rotation is always about the z-axis, with positive RotationAngleInDegrees values resulting in a clockwise rotation and negative values resulting in a counter-clockwise rotation. For specifying RotationAngle in radians, use [CompositionClip.RotationAngle](compositionclip_rotationangle.md). If both [CompositionClip.RotationAngle](compositionclip_rotationangle.md) and CompositionClip.RotationAngleInDegrees are set on the same [CompositionClip](compositionclip.md) object, whichever value is set last will override the other value.

By default, the RotationAngleInDegrees value on a clip is (0, 0).

## -remarks

## -examples

## -see-also
[CompositionClip.RotationAngle](compositionclip_rotationangle.md), [Visual.RotationAngle](visual_rotationangle.md)
