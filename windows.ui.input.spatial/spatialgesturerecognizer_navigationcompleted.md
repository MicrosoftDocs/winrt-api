---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationCompleted
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NavigationCompleted<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialNavigationCompletedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationCompleted

## -description

Occurs when a [Navigation](spatialgesturesettings.md) gesture is completed.

## -remarks

For hand interactions, the [SpatialNavigationCompletedEventArgs](spatialnavigationcompletedeventargs.md) event fires when the finger is released after a [NavigationStarted](spatialgesturerecognizer_navigationstarted.md) event.

For speech interactions, this event does not fire.

For motion controller interactions, this event fires when the Select trigger or button is released after a [NavigationStarted](spatialgesturerecognizer_navigationstarted.md) event.

## -examples

## -see-also
