---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.ManipulationCanceled
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ManipulationCanceled<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialManipulationCanceledEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.ManipulationCanceled

## -description

Occurs when a [Manipulation](spatialgesturesettings.md) gesture is canceled.

## -remarks

For hand interactions, the [SpatialManipulationCanceledEventArgs](spatialmanipulationcanceledeventargs.md) event fires when the [ManipulationStarted](spatialgesturerecognizer_manipulationstarted.md) hand is lost during the gesture.

For speech and motion controller interactions, this event does not fire.

## -examples

## -see-also
