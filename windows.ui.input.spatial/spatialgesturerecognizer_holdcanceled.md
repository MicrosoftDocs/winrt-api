---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.HoldCanceled
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler HoldCanceled<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialHoldCanceledEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.HoldCanceled

## -description

Occurs when a [Hold](spatialgesturesettings.md) gesture is canceled.

## -remarks

For hand interactions, the [SpatialHoldCanceledEventArgs](spatialholdcanceledeventargs.md) event fires when the [HoldStarted](spatialgesturerecognizer_holdstarted.md) hand is lost during the gesture.

For speech interactions, this event does not fire.

For motion controller interactions, this event fires when the [HoldStarted](spatialgesturerecognizer_holdstarted.md) controller is lost during the gesture.

## -examples

## -see-also
