---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.ManipulationCanceled
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ManipulationCanceled<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialManipulationCanceledEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.ManipulationCanceled

## -description
Occurs when a Manipulation gesture is canceled.

## -remarks
For hand interactions, the [SpatialManipulationCanceledEventArgs](spatialmanipulationcanceledeventargs.md) event fires when the relevant hand that had a ManipulationStarted is lost during the gesture.

For voice interactions and motion controllers, this event does not fire.

## -examples

## -see-also