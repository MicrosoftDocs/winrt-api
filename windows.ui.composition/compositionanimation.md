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
Value parameters (as opposed to reference parameters which are set using [SetReferenceParameter](compositionanimation_setreferenceparameter.md)) are copied and "embedded" into an expression at the time [CompositionObject::StartAnimation](compositionobject_startanimation.md) is called. Changing the value of the variable after [CompositionObject::StartAnimation](compositionobject_startanimation.md) is called will not affect the value of the [ExpressionAnimation](expressionanimation.md). See the remarks section of [ExpressionAnimation](expressionanimation.md) for additional information.

## -examples

## -see-also
[Composition Animations Overview](http://go.microsoft.com/fwlink/p/?LinkID=692060), [CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md)