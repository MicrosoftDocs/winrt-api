---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.RecognitionEnded
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler RecognitionEnded<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialRecognitionEndedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.RecognitionEnded

## -description
Occurs when recognition of gestures is done, either due to completion of a gesture or cancellation. This is the last event to fire.

## -remarks
For hand interactions, this event fires on finger release.

For voice interactions, this event fires after a system voice command like "Select" has been processed.

For spatial controllers, this event fires when the Select trigger or button is released.

This also fires if the relevant interaction source is lost during recognition.

## -examples

## -see-also
