---
-api-id: P:Windows.Media.Capture.MediaCapture.VideoDeviceController
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Devices.VideoDeviceController VideoDeviceController { get; }
-->

# Windows.Media.Capture.MediaCapture.VideoDeviceController

## -description
Gets an object that controls settings for the video camera.

## -property-value
A [VideoDeviceController](../windows.media.devices/videodevicecontroller.md) object.

## -remarks
Some drivers may require that the camera device preview to be in a running state before it can determine which controls are supported by the [VideoDeviceController](mediacapture_videodevicecontroller.md). If you check whether a certain control is supported by the [VideoDeviceController](mediacapture_videodevicecontroller.md) before the preview stream is running, the control may be described as unsupported even though it is supported by the video device.

## -examples

## -see-also


## -capabilities
backgroundMediaRecording
microphone, webcam
