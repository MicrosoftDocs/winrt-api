---
-api-id: P:Windows.Media.Capture.MediaCapture.ThermalStatus
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Capture.MediaCaptureThermalStatus ThermalStatus { get; }
-->

# Windows.Media.Capture.MediaCapture.ThermalStatus

## -description
Gets a value that indicates the current thermal status of the capture device.

## -property-value
A value that indicates the current thermal status of the capture device.

## -remarks
Media capture scenarios that are extremely processor-intensive, such as high-resolution, high-frame rate, and real-time image processing can cause the capture hardware to overheat. On devices where the camera driver supports reporting of thermal status, you can check the **ThermalStatus** property to get the current thermal status of the capture device. You can also subscribe to the [ThermalStatusChanged](mediacapture_thermalstatuschanged.md) event to receive a notification when the thermal status changes. If the thermal status is [Overheated](mediacapturethermalstatus.md) , you should stop the current capture session and save any captured media. Once the thermal status has returned to normal, you can begin capturing again.

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
