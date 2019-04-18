---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.ManipulationStarted
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ManipulationStarted<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialManipulationStartedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.ManipulationStarted

## -description

Occurs when an interaction becomes a [Manipulation](spatialgesturesettings.md) gesture.

## -remarks

For hand interactions, the [SpatialManipulationStartedEventArgs](spatialmanipulationstartedeventargs.md) event fires when a finger is pressed and then moves outside of the small Manipulation dead-zone.

For speech and motion controller interactions, this event does not fire.

## -examples

## -see-also
