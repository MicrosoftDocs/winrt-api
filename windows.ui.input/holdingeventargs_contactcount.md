---
-api-id: P:Windows.UI.Input.HoldingEventArgs.ContactCount
-api-type: winrt property
---

<!-- Property syntax.
public uint ContactCount { get; }
-->

# Windows.UI.Input.HoldingEventArgs.ContactCount

## -description

Gets the number of contact points at the time the [Holding](gesturerecognizer_holding.md) event is recognized.

## -property-value

The number of contact points.

## -remarks

[CurrentContactCount](holdingeventargs_currentcontactcount.md) returns the number of active contacts. This number might or might not be equal to ContactCount as contacts can be added or removed after the gesture starts.

## -see-also

## -examples
