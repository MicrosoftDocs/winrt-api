---
-api-id: T:Windows.UI.Core.AnimationMetrics.PropertyAnimationType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Core.AnimationMetrics.PropertyAnimationType : int
-->

# PropertyAnimationType

## -description
Specifies the animation type represented by a [PropertyAnimation](propertyanimation.md) object.

## -enum-fields
### -field Scale:0
Animate the size of the object, magnifying or shrinking. The corresponding object is the [ScaleAnimation](scaleanimation.md).

### -field Translation:1
Move the object. The corresponding object is the [TranslationAnimation](translationanimation.md).

### -field Opacity:2
Animate the object's transparency. The corresponding object is the [OpacityAnimation](opacityanimation.md).


## -remarks
All of the animation objects inherit from [IPropertyAnimation](ipropertyanimation.md). When they are retrieved through [AnimationDescription.Animations](animationdescription_animations.md), they are retrieved as generic [IPropertyAnimation](ipropertyanimation.md) objects. The caller then checks the [Type](ipropertyanimation_type.md) property, which provides one of the type values defined in this topic. The caller can then cast the [IPropertyAnimation](ipropertyanimation.md) object to the specific animation object to access any additional properties it provides.

## -examples

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
