---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationUpdated
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NavigationUpdated<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialNavigationUpdatedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationUpdated

## -description
Occurs when a Navigation gesture is updated due to hand or motion controller movement.

## -remarks
For hand interactions, the [SpatialNavigationUpdatedEventArgs](spatialnavigationupdatedeventargs.md) event fires when the relevant hand that had a NavigationStarted updates its position.

For voice interactions, this event does not fire.

For motion controllers, this event fires when the relevant controller that had a NavigationStarted is moved.

## -examples

## -see-also