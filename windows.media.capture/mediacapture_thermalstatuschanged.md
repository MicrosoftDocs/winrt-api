---
-api-id: E:Windows.Media.Capture.MediaCapture.ThermalStatusChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ThermalStatusChanged<Windows.Media.Capture.MediaCapture,  object>
-->

# Windows.Media.Capture.MediaCapture.ThermalStatusChanged

## -description
Occurs when the thermal status of the capture device changes.

## -remarks
Media capture scenarios that are extremely processor-intensive, such as high-resolution, high-frame rate, and real-time image processing can cause the capture hardware to overheat. On devices where the camera driver supports reporting of thermal status, you can check the [MediaCaptureThermalStatus](mediacapture_thermalstatus.md) property to get the current thermal status of the capture device. You can also subscribe to the [ThermalStatusChanged](mediacapture_thermalstatuschanged.md) event to receive a notification when the thermal status changes. If the thermal status is [Overheated](mediacapturethermalstatus.md) , you should stop the current capture session and save any captured media. Once the thermal status has returned to normal, you can begin capturing again.

## -examples

## -see-also
