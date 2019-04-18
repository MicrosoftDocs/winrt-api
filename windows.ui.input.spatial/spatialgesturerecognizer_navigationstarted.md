---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationStarted
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler NavigationStarted<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialNavigationStartedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.NavigationStarted

## -description

Occurs when an interaction becomes a [Navigation](spatialgesturesettings.md) gesture.

## -remarks

For hand interactions, the [SpatialNavigationStartedEventArgs](spatialnavigationstartedeventargs.md) event fires when a finger is pressed and then moves outside of the small Navigation dead-zone.

For voice interactions, this event does not fire.

For motion controller interactions, this event fires when the Select trigger or button is pressed followed by the controller moving outside of the small Navigation dead-zone.

## -examples

## -see-also
