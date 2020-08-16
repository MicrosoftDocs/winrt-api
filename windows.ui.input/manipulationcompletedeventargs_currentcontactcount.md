---
-api-id: P:Windows.UI.Input.ManipulationCompletedEventArgs.CurrentContactCount
-api-type: winrt property
---

<!-- Property syntax.
public uint CurrentContactCount { get; }
-->

# Windows.UI.Input.ManipulationCompletedEventArgs.CurrentContactCount

## -description

Gets the current number of contact points for the ongoing [Windows.UI.Input.GestureRecognizer.ManipulationCompleted](gesturerecognizer_manipulationcompleted.md) event.

## -property-value

The number of contact points.

## -remarks

[ContactCount](manipulationcompletedeventargs_contactcount.md) always returns the number of contacts detected when the current manipulation started.

CurrentContactCount returns the number of active contacts. This number might or might not be equal to ContactCount as contacts can be added or removed after the manipulation starts.

## -see-also

## -examples
