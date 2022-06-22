---
-api-id: T:Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier
-api-type: winrt class
---

<!-- Class syntax.
public class InteractionTrackerInertiaModifier : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.Interactions.IInteractionTrackerInertiaModifier
-->

# Windows.UI.Composition.Interactions.InteractionTrackerInertiaModifier

## -description
Base class for inertia modifiers.

The InteractionTrackerInertiaModifier represents the base class for inertia modifiers. inertia modifiers can be thought of as ways to change the behavior for where and how [InteractionTracker](interactiontracker.md) reaches its final resting position. Changing this behavior of [InteractionTracker](interactiontracker.md) is commonly used when more custom motion experiences are needed such as snap points. There are two variations to how you can modify the behavior of [InteractionTracker](interactiontracker.md) using inertia modifiers: modify its final resting position after interaction with the [InteractionTrackerInertiaRestingValue](interactiontrackerinertiarestingvalue.md) class or define the equation used to calculate the actual motion and final resting position during Inertia with the [InteractionTrackerInertiaMotion](interactiontrackerinertiamotion.md) class. These modifiers are applied to either X Position, Y Position or Scale of [InteractionTracker](interactiontracker.md).



## -remarks
It is important to note that inertia modifiers only get evaluated when [InteractionTracker](interactiontracker.md) enters the Inertia state. Once the [InteractionTracker](interactiontracker.md) has entered inertia, all the inertia modifiers are evaluated and if one is selected, it will be used to calculate the motion until [InteractionTracker](interactiontracker.md) ’s velocity becomes 0.

## -examples

## -see-also
[CompositionObject](../windows.ui.composition/compositionobject.md), [IClosable](../windows.foundation/iclosable.md)
