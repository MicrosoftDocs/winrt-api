---
-api-id: T:Windows.Media.Devices.TorchControl
-api-type: winrt class
---

<!-- Class syntax.
public class TorchControl : Windows.Media.Devices.ITorchControl
-->

# Windows.Media.Devices.TorchControl

## -description
Provides functionality for controlling the torch LED settings on a capture device.

## -remarks
The TorchControl enables apps to manage the torch LED on a device. This can used in capture apps or in non-capture app to do things like brighten a room.

You can find out if a device supports this control by checking [TorchControl.Supported](torchcontrol_supported.md).

You can access the TorchControl for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

For how-to guidance for using the **TorchControl**, see [Camera-independent Flashlight](/windows/uwp/audio-video-camera/camera-independent-flashlight).

## -examples

## -see-also
[MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md)
