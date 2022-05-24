---
-api-id: T:Windows.Media.Devices.ExposureControl
-api-type: winrt class
---

<!-- Class syntax.
public class ExposureControl : Windows.Media.Devices.IExposureControl
-->

# Windows.Media.Devices.ExposureControl

## -description
Provides functionality for controlling the exposure settings on a capture device.

## -remarks
The **ExposureControl** gives apps additional control over the exposure settings on a device.

To set an exposure value, call [SetValueAsync](exposurecontrol_setvalueasync_1247308686.md). To turn auto exposure on, call [SetAutoAsync](exposurecontrol_setautoasync_1168787363.md).

You can find out if a device supports this control by checking [ExposureControl.Supported](exposurecontrol_supported.md).

If the device does not support the ExposureControl, you can still use the [Exposure](videodevicecontroller_exposure.md) property on the [VideoCaptureDevice](https://msdn.microsoft.com/library/afba2768-11a0-4105-a5b1-c48bc961e9ed) to set the exposure value.

You can access the **ExposureControl** for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

For how-to guidance for using the **ExposureControl**, see [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture).

## -examples

## -see-also
[Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture)
