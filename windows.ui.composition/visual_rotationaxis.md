---
-api-id: P:Windows.UI.Composition.Visual.RotationAxis
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 RotationAxis { get;  set; }
-->

# Windows.UI.Composition.Visual.RotationAxis

## -description
The axis to rotate the visual around. Animatable.



## -property-value
The axis to rotate the visual around. For example, a value of Vector3(1,0,0) indicates rotation along the x-axis.

## -remarks

This property can be animated. Call [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) to associate it with a [CompositionAnimation](/windows/uwp/composition/composition-animation).

[Visual](visual.md) supports two forms of rotation, by axis-angle, and by orientation.

## -examples

## -see-also
