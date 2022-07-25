---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.CreateWithOwner(Windows.UI.Composition.Compositor,Windows.UI.Composition.Interactions.IInteractionTrackerOwner)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.Interactions.InteractionTracker CreateWithOwner(Windows.UI.Composition.Compositor compositor, Windows.UI.Composition.Interactions.IInteractionTrackerOwner owner)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.CreateWithOwner

## -description
Creates an instance of [InteractionTracker](interactiontracker.md) with the specified owner.

This Create method will instantiate an [InteractionTracker](interactiontracker.md) with an owner for registering for callbacks. After creating the [InteractionTracker](interactiontracker.md) setting the properties, attaching a [VisualInteractionSource](visualinteractionsource.md), and referencing position or scale in an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md), active input can drive the [ExpressionAnimation](../windows.ui.composition/expressionanimation.md). Creating the [InteractionTracker](interactiontracker.md) with an owner is only required if the application needs to receive callbacks regarding state and values of the [InteractionTracker](interactiontracker.md).



## -parameters
### -param compositor
The compositor to use to create the instance of [InteractionTracker](interactiontracker.md).

### -param owner
The [InteractionTracker](interactiontracker.md) owner to associate with the created [InteractionTracker](interactiontracker.md).

## -returns
Returns the created [InteractionTracker](interactiontracker.md) object.

## -remarks

## -examples

## -see-also
