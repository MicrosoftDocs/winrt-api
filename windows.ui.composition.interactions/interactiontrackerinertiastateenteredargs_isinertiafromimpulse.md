---
-api-id: P:Windows.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs.IsInertiaFromImpulse
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsInertiaFromImpulse { get; }
-->

# Windows.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs.IsInertiaFromImpulse

## -description

Gets a value that indicates whether the inertia is the result of an impulse.



## -property-value

**true** if the inertia is the result of an impulse; otherwise, **false**.

## -remarks

Inertia from an impulse includes both calls to TryUpdatePositionWithInitialVelocity, and auto-redirected pointer wheel input. This property evaluates to **true** [within an expression](interactiontracker_isinertiafromimpulse.md) when the input originates from a discrete source such as a pointer wheel.

You can reference this property in the expression used to select an [inertia modifier](interactiontrackerinertiamodifier.md), which allows you to determine whether the inertia is being entered as a result of pointer wheel input. You can then provide different inertia modifiers for these types of interactions than you provide for continuous manipulations, like touch and touchpad.

For example, when scrolling a page of content, a small touch delta can result in the content getting snapped back to its original starting value. However, when scrolling with the pointer wheel, each tick of the wheel should move the content a full page per tick. You can define snap points (inertia modifiers) for use with the pointer wheel that will snap scrolling to a desired endpoint, but specify different criteria for the snap points that are used with touch or direct manipulation.

## -see-also

[Create snap points with inertia modifiers](/windows/uwp/composition/inertia-modifiers), [InteractionTracker_IsInertiaFromImpulse](interactiontracker_isinertiafromimpulse.md), [InteractionTrackerInertiaModifier](interactiontrackerinertiamodifier.md)

## -examples

