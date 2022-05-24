---
-api-id: T:Windows.Media.Devices.DigitalWindowControl
-api-type: winrt class
---

# Windows.Media.Devices.DigitalWindowControl

<!--
public sealed class DigitalWindowControl
-->


## -description

Allows apps to capture a subregion of the capture device's sensor. For cameras that offer high-resolution native sensors, this feature enables digital pan, tilt, and zoom  and allow apps to obtain higher detail images of such objects without the need to change media resolutions.

## -remarks

Access the **DigitalWindowControl** for the capture device by accessing the [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md) property and then the [VideoDeviceController.DigitalWindowControl](videodevicecontroller_digitalwindowcontrol.md) property. Determine if the controls is supported by the capture device by checking [DigitalWindowControl.IsSupported](digitalwindowcontrol_issupported.md).

For more information on using the **DigitalWindowControl** in your app, see [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture).

## -see-also

[Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture)

## -examples


