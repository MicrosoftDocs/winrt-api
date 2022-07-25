---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion.Motion
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.ExpressionAnimation Motion { get;  set; }
-->

# Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion.Motion

## -description
An [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) describing the modified motion for [InteractionTracker](interactiontracker.md) if the expression in the Condition property is true.

The Motion property is an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) that describes the motion [InteractionTracker](interactiontracker.md) will utilize during Inertia when the corresponding condition is met. The expression will be evaluated every frame while [InteractionTracker](interactiontracker.md) is in Inertia and must resolve to a type Float, otherwise an error will be thrown when the equation is evaluated. See the [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) class page for more details on building expressions.



## -property-value
An [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) describing the modified motion for [InteractionTracker](interactiontracker.md) if the expression in the Condition property is true.

## -remarks

## -examples

## -see-also
