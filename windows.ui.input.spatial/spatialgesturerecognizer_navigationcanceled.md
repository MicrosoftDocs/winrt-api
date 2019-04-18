---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationCanceled
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NavigationCanceled<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialNavigationCanceledEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationCanceled

## -description

Occurs when a [Navigation](spatialgesturesettings.md) gesture is canceled.

## -remarks

For hand interactions, the [SpatialNavigationCanceledEventArgs](spatialnavigationcanceledeventargs.md) event fires when the [NavigationStarted](spatialgesturerecognizer_navigationstarted.md) hand is lost during the gesture.

For speech interactions, this event does not fire.

For motion controller interactions, this event fires when the [NavigationStarted](spatialgesturerecognizer_navigationstarted.md) controller is lost during the gesture.

## -examples

## -see-also
