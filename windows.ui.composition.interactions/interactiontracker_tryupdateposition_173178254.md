---
-api-id: M:Windows.UI.Composition.Interactions.InteractionTracker.TryUpdatePosition(Windows.Foundation.Numerics.Vector3,Windows.UI.Composition.Interactions.InteractionTrackerClampingOption,Windows.UI.Composition.Interactions.InteractionTrackerPositionUpdateOption)
-api-type: winrt method
---

<!-- Method syntax.
public int InteractionTracker.TryUpdatePosition(Vector3 value, InteractionTrackerClampingOption option, InteractionTrackerPositionUpdateOption posUpdateOption)
-->

# Windows.UI.Composition.Interactions.InteractionTracker.TryUpdatePosition

## -description

Tries to update the position of the [InteractionTracker](interactiontracker.md) using the specified clamping option.



## -parameters

### -param value

The new position for the [InteractionTracker](interactiontracker.md).

### -param option

A value that specifies how values are clamped to the maximum and minimum.

### -param posUpdateOption

A value that specifies whether an already running custom scale animation should be allowed to continue running.

## -returns

Returns the request ID. On state transitions, the request which caused the change in state will be included in the args. These IDs will start at 1 and increase with each try call during the lifetime of the application.

## -remarks

## -see-also

## -examples

