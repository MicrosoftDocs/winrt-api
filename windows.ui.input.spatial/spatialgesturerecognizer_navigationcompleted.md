---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationCompleted
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NavigationCompleted<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialNavigationCompletedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationCompleted

## -description
Occurs when a Navigation gesture is completed.

## -remarks
For hand interactions, the [SpatialNavigationCompletedEventArgs](spatialnavigationcompletedeventargs.md) event fires when the finger is released after NavigationStarted.

For voice interactions, this event does not fire.

For motion controllers, this event fires when the Select trigger or button is released after NavigationStarted.

## -examples

## -see-also