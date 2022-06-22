---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTracker.Scale
-api-type: winrt property
---

<!-- Property syntax
public float Scale { get; }
-->

# Windows.UI.Composition.Interactions.InteractionTracker.Scale

## -description
The output scale calculated by the [InteractionTracker](interactiontracker.md). The current scale is a relative value that depends on the values specified in the [MinScale](interactiontracker_minscale.md) and [MaxScale](interactiontracker_maxscale.md) properties.

The scale property of the [InteractionTracker](interactiontracker.md) is a float representing the scale in the [InteractionTracker](interactiontracker.md) ’s coordinate space. This value will start at 1 and will increase or decrease based on active input or direct calls to update or animate the property. The scale property when the [InteractionTracker](interactiontracker.md) is in the Idle or CustomAnimation states will not change from 1 unless the [MinScale](interactiontracker_minscale.md) and [MaxScale](interactiontracker_maxscale.md) properties, which both default to 1, are updated. [InteractionTracker](interactiontracker.md) ’s scale can go slightly outside this range during the Interacting and Inertia states in order to show a bounce or resistance at the boundary.



## -property-value
The output scale calculated by the [InteractionTracker](interactiontracker.md).

## -remarks
The [InteractionTracker](interactiontracker.md) scale is populated either by active input through the [VisualInteractionSource](visualinteractionsource.md) or by direct calls to update the scale. Active “pinch” input will update the [InteractionTracker](interactiontracker.md) ’s scale property if configured. All calls to animate or update the scale accept float input. The scale property referenced in an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md) will always reflect the current scale of the [InteractionTracker](interactiontracker.md) taking into account factors such as boundaries and inertia modifiers.

## -examples

## -see-also
