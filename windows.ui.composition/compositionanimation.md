---
-api-id: T:Windows.UI.Composition.CompositionAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionAnimation : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionAnimation, Windows.UI.Composition.ICompositionAnimation2, Windows.UI.Composition.ICompositionAnimationBase
-->

# Windows.UI.Composition.CompositionAnimation

## -description
Represents the base animation class.



## -remarks

This is the base class for [ExpressionAnimation](expressionanimation.md) and [KeyFrameAnimation](keyframeanimation.md).

Use the [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md) and [CompostionObject.StopAnimation](compositionobject_stopanimation_1075337060.md) methods to start and stop the animation.

Value parameters (as opposed to reference parameters which are set using [SetReferenceParameter](compositionanimation_setreferenceparameter_486390519.md)) are copied and "embedded" into an expression at the time [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) is called. Changing the value of the variable after [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) is called will not affect the value of the [ExpressionAnimation](expressionanimation.md). See the remarks section of [ExpressionAnimation](expressionanimation.md) for additional information.

For a list of animatable properties, see the remarks on [CompostionObject.StartAnimation](compositionobject_startanimation_709050842.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | SetBooleanParameter |
| 1607 | 14393 | Target |
| 1709 | 16299 | InitialValueExpressions |
| 1809 | 17763 | SetExpressionReferenceParameter |

## -examples

## -see-also

[ExpressionAnimation](expressionanimation.md), [KeyFrameAnimation](keyframeanimation.md), [Composition Animations Overview](/windows/uwp/composition/composition-animation), [CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md)
