---
-api-id: P:Windows.UI.Core.AnimationMetrics.AnimationDescription.Animations
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Core.AnimationMetrics.IPropertyAnimation> Animations { get; }
-->

# Windows.UI.Core.AnimationMetrics.AnimationDescription.Animations

## -description
Gets the collection of animations that are associated with the [AnimationDescription](animationdescription.md) object.

## -property-value
A collection of [IPropertyAnimation](ipropertyanimation.md) instances, each of which represents an animation effect specified for this [AnimationDescription](animationdescription.md) object.

## -remarks
The returned animations should be applied to the object in the order they appear in the collection array. If two or more animations apply to an object, they will appear in the array in this order:

1. Scale
1. Translate
1. Opacity
If the animations are being applied to more than one object, then the stagger-related properties ([StaggerDelay](animationdescription_staggerdelay.md) and [StaggerDelayFactor](animationdescription_staggerdelayfactor.md)) describe the relative timing among the objects.

## -examples

## -see-also
[PropertyAnimationType](propertyanimationtype.md), [Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
