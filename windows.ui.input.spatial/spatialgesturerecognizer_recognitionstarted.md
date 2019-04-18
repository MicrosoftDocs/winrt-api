---
-api-id: E:Windows.UI.Input.Spatial.SpatialGestureRecognizer.RecognitionStarted
-api-type: winrt event
-api-device-family-note: xbox
ms.custom: 19H1
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler RecognitionStarted<Windows.UI.Input.Spatial.SpatialGestureRecognizer,  Windows.UI.Input.Spatial.SpatialRecognitionStartedEventArgs>
-->

# Windows.UI.Input.Spatial.SpatialGestureRecognizer.RecognitionStarted

## -description

Occurs when gesture recognition begins (this is the first event to fire).

## -remarks

The [SpatialRecognitionStartedEventArgs](spatialrecognitionstartedeventargs.md) event fires when there is no active gesture and the gesture recognizer is told to capture an interaction. Events only fire if the interaction can trigger at least one of the gestures requested in [SpatialGestureSettings](spatialgesturesettings.md).

For hand interactions, this event fires on finger press.

For speech interactions, this event fires when a system voice command such as "Select" is spoken.

For motion controllers, this event fires when the Select trigger or button is pressed.

## -examples

## -see-also
