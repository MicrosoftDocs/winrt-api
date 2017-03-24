---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.RecognitionStarted
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler RecognitionStarted<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialRecognitionStartedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.RecognitionStarted

## -description
Occurs when recognition of gestures begins. This is the first event to fire.

## -remarks
This event fires when there is no active gesture and the gesture recognizer is told to capture an interaction. Note that events will only fire if the interaction could possibly trigger at least one of the gestures requested in the SpatialGestureSettings.

For hand interactions, this event fires on finger press.

For voice interactions, this event fires when a system voice command like "Select" is spoken.

For spatial controllers, this event fires when the Select trigger or button is pressed.

## -examples

## -see-also
