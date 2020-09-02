---
-api-id: T:Windows.Media.Devices.WhiteBalanceControl
-api-type: winrt class
---

<!-- Class syntax.
public class WhiteBalanceControl : Windows.Media.Devices.IWhiteBalanceControl
-->

# Windows.Media.Devices.WhiteBalanceControl

## -description
Provides functionality for controlling the white balance settings on a capture device.

## -remarks
The WhiteBalanceControl gives apps additional control over the white balance settings on a device. You can use one of the [ColorTemperaturePreset](colortemperaturepreset.md) values by calling [SetPresetAsync](whitebalancecontrol_setpresetasync_1724838565.md). Or call [SetValueAsync](whitebalancecontrol_setvalueasync_2096210171.md) to set a specific [Value](whitebalancecontrol_value.md) between the [Min](whitebalancecontrol_min.md) and [Max ](whitebalancecontrol_max.md).

You can find out if a device supports this control by checking [WhiteBalanceControl.Supported](whitebalancecontrol_supported.md).

If the device does not support the WhiteBalanceControl, you can still use the [WhiteBalance](videodevicecontroller_whitebalance.md) on the [VideoCaptureDevice](https://msdn.microsoft.com/library/afba2768-11a0-4105-a5b1-c48bc961e9ed) to set the value for the white balance color temperature.

You can access the WhiteBalanceControl for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

White balance is specified as a color temperature in degrees Kelvin.

For how-to guidance for using the **FocusControl**, see [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture).

## -examples

## -see-also
[MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md), [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture)
