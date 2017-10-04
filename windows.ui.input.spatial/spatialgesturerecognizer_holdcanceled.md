---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.HoldCanceled
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler HoldCanceled<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialHoldCanceledEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.HoldCanceled

## -description
Occurs when a Hold gesture is canceled.

## -remarks
For hand interactions, the [SpatialHoldCanceledEventArgs](spatialholdcanceledeventargs.md) event fires when the relevant hand that had a HoldStarted is lost during the gesture.

For voice interactions, this event does not fire.

For motion controllers, this event fires when the relevant controller that had a HoldStarted is lost during the gesture.

## -examples

## -see-also