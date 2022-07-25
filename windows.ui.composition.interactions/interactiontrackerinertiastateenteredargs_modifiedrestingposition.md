---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs.ModifiedRestingPosition
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.Numerics.Vector3> ModifiedRestingPosition { get; }
-->

# Windows.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs.ModifiedRestingPosition

## -description
The [InteractionTracker](interactiontracker.md)'s resting position when inertia completes after [InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md)s and boundaries have been applied.

The ModifiedRestingPosition property represents the systems calculation of where the final resting position of [InteractionTracker](interactiontracker.md) will be based on an interaction. Unlike the [NaturalRestingPosition](interactiontrackerinertiastateenteredargs_naturalrestingposition.md), ModifiedRestingPosition will be calculated based on other factors that affect the motion of [InteractionTracker](interactiontracker.md) such as InertiaModifiers and Min/Max boundaries.



## -property-value
The [InteractionTracker](interactiontracker.md)'s resting position when inertia completes after [InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md)s and boundaries have been applied.

## -remarks

## -examples

## -see-also
