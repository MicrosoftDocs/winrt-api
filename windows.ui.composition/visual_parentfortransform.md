---
-api-id: P:Windows.UI.Composition.Visual.ParentForTransform
-api-type: winrt property
---

<!-- Property syntax.
public Visual ParentForTransform { get;  set; }
-->

# Windows.UI.Composition.Visual.ParentForTransform

## -description
Visual specifying the coordinate system in which this visual is composed.



## -property-value
Visual specifying the coordinate system in which this visual is composed.

## -remarks
ParentForTransform allows you to change the coordinate system in which a visual is composed. You can specify another visual that acts as a visual's "transform parent". That is, the visual in question will inherit accumulated transforms as though it were the child of that other visual. Note that this includes the effects of all properties that relate to transform, such as Visual.RotationAngle, or Visual.AnchorPoint, on the specified "transform parent" visual and all of its "transform ancestors". 

## -see-also

## -examples

