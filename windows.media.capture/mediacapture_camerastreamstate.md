---
-api-id: P:Windows.Media.Capture.MediaCapture.CameraStreamState
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Devices.CameraStreamState CameraStreamState { get; }
-->

# Windows.Media.Capture.MediaCapture.CameraStreamState

## -description
Gets the current stream state of the camera stream.

## -property-value
The current stream state of the camera stream.

## -remarks
The state of the camera stream will change when recording is paused or resumed, when the system drops frames for privacy reasons, or when the camera stream is lost. To be notified when the camera stream state changes, handle the [CameraStreamStateChanged](mediacapture_camerastreamstatechanged.md) event.

## -examples

## -see-also
[CameraStreamState](../windows.media.devices/camerastreamstate.md), [CameraStreamStateChanged](mediacapture_camerastreamstatechanged.md)