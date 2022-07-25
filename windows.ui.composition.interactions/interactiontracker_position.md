---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTracker.Position
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 Position { get; }
-->

# Windows.UI.Composition.Interactions.InteractionTracker.Position

## -description
The output position calculated by the [InteractionTracker](interactiontracker.md). The current position is a relative value. During the Idle and CustomAnimation states, it will always be between the values specified in the MinPosition and MaxPosition properties. The InteractionTracker’s position property can go outside this range during the Interacting and Inertia states in order to show a bounce or resistance at the boundary.

The position property of the InteractionTracker is a Vector3 representing position in the X, Y, and Z axis. The X and Y channels are the only components that will be updated by the InteractionTracker at this point. The channels of this Vector3 will not fluctuate outside of 0 (the default value) if the MinPosition and MaxPosition are not set.



## -property-value
The output position calculated by the [InteractionTracker](interactiontracker.md).

## -remarks
The [InteractionTracker](interactiontracker.md) position is populated either by active input through the [VisualInteractionSource](visualinteractionsource.md) or by direct calls to update the position. Active vertical or horizontal panning will respectively update the Y and X channels of the Vector3. All calls to animate or update the position accept Vector3 input and each channel can be evaluated individually. The position property used in an ExpressionAnimation will always reflect the current position of the [InteractionTracker](interactiontracker.md) taking into account factors such as boundaries and inertia modifiers.

## -examples

## -see-also
[ExpressionAnimation](../windows.ui.composition/expressionanimation.md)
