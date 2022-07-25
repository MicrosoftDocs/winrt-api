---
-api-id: P:Windows.UI.Composition.Visual.RotationAngle
-api-type: winrt property
---

<!-- Property syntax
public float RotationAngle { get;  set; }
-->

# Windows.UI.Composition.Visual.RotationAngle

## -description

The rotation angle in radians of the visual. Animatable.



## -property-value
The rotation angle in radians of the visual.

## -remarks

To use degrees instead of radians use [RotationAngleInDegrees](visual_rotationangleindegrees.md).

[Visual](visual.md) supports two forms of rotation, by axis-angle, and by orientation.

This property can be animated. Call [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) to associate it with a [CompositionAnimation](/windows/uwp/composition/composition-animation).

## -examples

## -see-also
