---
-api-id: T:Windows.UI.Composition.Vector4KeyFrameAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class Vector4KeyFrameAnimation : Windows.UI.Composition.KeyFrameAnimation, Windows.UI.Composition.IVector4KeyFrameAnimation
-->

# Windows.UI.Composition.Vector4KeyFrameAnimation

## -description
A time-based animation that targets any Vector4-based property with one or more keyframes.

## -remarks

Use the [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md) and [CompostionObject.StopAnimation](compositionobject_stopanimation_1075337060.md) methods to start and stop the animation.

An animation is associated with an object's property by calling [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md) and specifying the property name and the animation. See the remarks section of [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md) for a list of animatable properties.

## -examples

## -see-also
[Composition Animations Overview](https://docs.microsoft.com/en-us/windows/uwp/composition/composition-animation), [KeyFrameAnimation](keyframeanimation.md), [IClosable](../windows.foundation/iclosable.md)
