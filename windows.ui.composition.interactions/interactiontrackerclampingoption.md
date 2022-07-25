---
-api-id: T:Windows.UI.Composition.Interactions.InteractionTrackerClampingOption
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum InteractionTrackerClampingOption : int 
-->

# Windows.UI.Composition.Interactions.InteractionTrackerClampingOption

## -description

Defines constants that specify how values are clamped when the InteractionTracker position is updated.



## -enum-fields
### -field Disabled:1

If the input value is greater (or less) than the max (or min) value, it is not immediately clamped. Instead, the max/min is enforced to the newly input value of Position (and potentially clamped) the next time InteractionTracker enters the Inertia state.

### -field Auto:0

If the input value is greater (or less) than the max (or min) value, it is immediately clamped.

## -remarks

This enumeration provides values for the _option_ parameter of the [TryUpdatePosition](interactiontracker_tryupdateposition_2048659206.md) and [TryUpdatePositionBy](interactiontracker_tryupdatepositionby_788745142.md) methods.

Clamping is based on the values of InteractionTracker [MinPosition](interactiontracker_minposition.md)/[MaxPosition](interactiontracker_maxposition.md) and [MinScale](interactiontracker_minscale.md)/[MaxScale](interactiontracker_maxscale.md).

## -see-also

[TryUpdatePosition](interactiontracker_tryupdateposition_2048659206.md), [TryUpdatePositionBy](interactiontracker_tryupdatepositionby_788745142.md)

## -examples

