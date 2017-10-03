---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationCanceled
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NavigationCanceled<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialNavigationCanceledEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationCanceled

## -description
Occurs when a Navigation gesture is canceled.

## -remarks
For hand interactions, the [SpatialNavigationCanceledEventArgs](spatialnavigationcanceledeventargs.md) event fires when the relevant hand that had a NavigationStarted is lost during the gesture.

For voice interactions, this event does not fire.

For motion controllers, this event fires when the relevant controller that had a NavigationStarted is lost during the gesture.

## -examples

## -see-also