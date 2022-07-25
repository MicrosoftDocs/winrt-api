---
-api-id: T:Windows.UI.Composition.KeyFrameAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class KeyFrameAnimation : Windows.UI.Composition.CompositionAnimation, Windows.UI.Composition.IKeyFrameAnimation, Windows.UI.Composition.IKeyFrameAnimation2, Windows.UI.Composition.IKeyFrameAnimation3
-->

# Windows.UI.Composition.KeyFrameAnimation

## -description
A time-based animation with one or more key frames. These frames are markers, allowing developers to specify values at specific times for the animating property. KeyFrame animations can be further customized by specifying how the animation interpolates between keyframes.



## -remarks

An animation is associated with an object's property by calling [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) and specifying the property name and the animation. See the remarks section of [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) for a list of animatable properties. See [Composition Animations Overview](/windows/uwp/composition/composition-animation) for additional information on [ExpressionAnimation](expressionanimation.md)s.

A KeyFrameAnimation does not stop automatically when an app's process is suspended. You must subscribe to app state events and stop or pause your animations before the app is suspended. For more info about app suspension, see [App lifecycle](/windows/uwp/launch-resume/app-lifecycle).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | Direction |
| 1703 | 15063 | DelayBehavior |

## -examples

## -see-also
[Composition Animations Overview](/windows/uwp/composition/composition-animation), [CompositionAnimation](compositionanimation.md), [IClosable](../windows.foundation/iclosable.md)
