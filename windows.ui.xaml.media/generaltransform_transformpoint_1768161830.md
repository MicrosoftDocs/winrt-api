---
-api-id: M:Windows.UI.Xaml.Media.GeneralTransform.TransformPoint(Windows.Foundation.Point)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Point TransformPoint(Windows.Foundation.Point point)
-->

# Windows.UI.Xaml.Media.GeneralTransform.TransformPoint

## -description
Uses this transformation object's logic to transform the specified point, and returns the result.



## -parameters
### -param point
The point to transform using the transformation logic.

## -returns
The result of transforming *point*.

## -remarks
The purpose of transformations is to convert data in coordinate systems to new frames of reference for a different coordinate system. Call this method to use the logic of this specific [Transform](transform.md) derived class in order to convert a [Point](../windows.foundation/point.md) of the initial coordinate system into a [Point](../windows.foundation/point.md) in the coordinate system as it's interpreted by the transformation.

## -examples

## -see-also
[TransformBounds](generaltransform_transformbounds_2050801728.md)
