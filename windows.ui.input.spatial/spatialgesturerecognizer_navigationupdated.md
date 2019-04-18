---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationUpdated
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NavigationUpdated<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialNavigationUpdatedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationUpdated

## -description

Occurs when a [Navigation](spatialgesturesettings.md) gesture is updated due to hand or motion controller movement.

## -remarks

For hand interactions, the [SpatialNavigationUpdatedEventArgs](spatialnavigationupdatedeventargs.md) event fires when the [NavigationStarted](spatialgesturerecognizer_navigationstarted.md) hand updates its position.

For voice interactions, this event does not fire.

For motion controller interactions, this event fires when the [NavigationStarted](spatialgesturerecognizer_navigationstarted.md) controller is moved.

## -examples

## -see-also
