---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.RecognitionEnded
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler RecognitionEnded<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialRecognitionEndedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.RecognitionEnded

## -description

Occurs when gesture recognition ends, due to completion or cancellation of a gesture (this is the last event to fire).

## -remarks

For hand interactions, the [SpatialRecognitionEndedEventArgs](spatialrecognitionendedeventargs.md) event fires on finger release.

For speech interactions, this event fires after a system voice command such as "Select" has been processed.

For motion controllers, this event fires when the Select trigger or button is released.

This event also fires if the relevant interaction source is lost during recognition.

## -examples

## -see-also
