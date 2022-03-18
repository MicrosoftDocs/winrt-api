---
-api-id: T:Windows.Media.Devices.FlashControl
-api-type: winrt class
---

<!-- Class syntax.
public class FlashControl : Windows.Media.Devices.IFlashControl, Windows.Media.Devices.IFlashControl2
-->

# Windows.Media.Devices.FlashControl

## -description
Provides functionality for controlling the flash settings on a capture device.

## -remarks
The FlashControl enable apps to manage the flash on a device. This can be used in a photo app to handle low-light conditions or for [RedEyeReduction](flashcontrol_redeyereduction.md).

You can find out if a device supports this control by checking [FlashControl.Supported](flashcontrol_supported.md).

You can access the FlashControl for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

For how-to guidance for using the **FlashControl**, see [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture).

## -examples

## -see-also
[Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture)
