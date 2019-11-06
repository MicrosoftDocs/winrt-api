---
-api-id: P:Windows.UI.Input.HoldingEventArgs.CurrentContactCount
-api-type: winrt property
---

<!-- Property syntax.
public uint CurrentContactCount { get; }
-->

# Windows.UI.Input.HoldingEventArgs.CurrentContactCount

## -description

Gets the current number of contact points for the ongoing [Windows.UI.Input.GestureRecognizer.Holding](gesturerecognizer_holding.md) event.

## -property-value

The number of contact points.

## -remarks

[ContactCount](holdingeventargs_contactcount.md) always returns the number of contacts detected when the current gesture started.

CurrentContactCount returns the number of active contacts. This number might or might not be equal to ContactCount as contacts can be added or removed after the gesture starts.

## -see-also

## -examples
