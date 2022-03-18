---
-api-id: P:Windows.UI.Input.ManipulationUpdatedEventArgs.ContactCount
-api-type: winrt property
---

<!-- Property syntax.
public uint ContactCount { get; }
-->

# Windows.UI.Input.ManipulationUpdatedEventArgs.ContactCount

## -description

Gets the number of contact points at the time the [ManipulationUpdated](gesturerecognizer_manipulationupdated.md) event is recognized.

## -property-value

The number of contact points.

## -remarks

[CurrentContactCount](manipulationupdatedeventargs_currentcontactcount.md) returns the number of active contacts. This number might or might not be equal to ContactCount as contacts can be added or removed after the manipulation starts.

## -see-also

## -examples
