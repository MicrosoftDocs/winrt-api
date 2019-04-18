---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.HoldCompleted
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler HoldCompleted<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialHoldCompletedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.HoldCompleted

## -description

Occurs when a [Hold](spatialgesturesettings.md) gesture completes.

## -remarks

For hand interactions, the [SpatialHoldCompletedEventArgs](spatialholdcompletedeventargs.md) event fires when the finger is released after [HoldStarted](spatialgesturerecognizer_holdstarted.md).

For speech interactions, this event does not fire.

For motion controller interactions, this event fires when the Select trigger or button is released after [HoldStarted](spatialgesturerecognizer_holdstarted.md).

## -examples

## -see-also
