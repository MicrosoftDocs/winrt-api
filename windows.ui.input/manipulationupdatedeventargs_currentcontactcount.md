---
-api-id: P:Windows.UI.Input.ManipulationUpdatedEventArgs.CurrentContactCount
-api-type: winrt property
---

<!-- Property syntax.
public uint CurrentContactCount { get; }
-->

# Windows.UI.Input.ManipulationUpdatedEventArgs.CurrentContactCount

## -description

Gets the current number of contact points for the ongoing [ManipulationUpdated](gesturerecognizer_manipulationupdated.md) event.

## -property-value

The number of contact points.

## -remarks

[ContactCount](manipulationupdatedeventargs_contactcount.md) always returns the number of contacts detected when the current manipulation started.

CurrentContactCount returns the number of active contacts. This number might or might not be equal to ContactCount as contacts can be added or removed after the manipulation starts.

## -see-also

## -examples
