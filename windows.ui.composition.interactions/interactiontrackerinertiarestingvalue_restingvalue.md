---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue.RestingValue
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.ExpressionAnimation RestingValue { get;  set; }
-->

# Windows.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue.RestingValue

## -description
An [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) to define the resting value of [InteractionTracker](interactiontracker.md) if the expression in the Condition property is true.

The Resting property is an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) that describes where [InteractionTracker](interactiontracker.md) will move to after an interaction if it’s corresponding condition is met. This expression will be run every frame while [InteractionTracker](interactiontracker.md) is in Inertia and must resolve to a type Float, otherwise an error will be thrown when the equation is evaluated. See the [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) class page for more details on building expressions.



## -property-value
An [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) to define the resting value if the expression in the Condition property is true.

## -remarks

## -examples

## -see-also
