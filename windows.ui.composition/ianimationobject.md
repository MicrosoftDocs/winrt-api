---
-api-id: T:Windows.UI.Composition.IAnimationObject
-api-type: winrt interface
ms.custom: RS5
---

<!-- Interface syntax.
public interface IAnimationObject 
-->

# Windows.UI.Composition.IAnimationObject

## -description

Represents an object that has properties that can be referenced by an animation.

## -remarks

Implement `IAnimationObject` to let a custom object participate in [ExpressionAnimation](expressionanimation.md)s. It redirects the property on the custom object to the underlying [CompositionObject](compositionobject.md). For more info, see [CompositionAnimation.SetExpressionReferenceParameter](compositionanimation_setexpressionreferenceparameter_171213698.md).

## -see-also

[CompositionAnimation.SetExpressionReferenceParameter](compositionanimation_setexpressionreferenceparameter_171213698.md)

## -examples

