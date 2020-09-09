---
-api-id: T:Windows.Media.Devices.IsoSpeedControl
-api-type: winrt class
---

<!-- Class syntax.
public class IsoSpeedControl : Windows.Media.Devices.IIsoSpeedControl, Windows.Media.Devices.IIsoSpeedControl2
-->

# Windows.Media.Devices.IsoSpeedControl

## -description
Provides functionality for controlling the ISO film speed settings on a capture device.

## -remarks
You can find out if a device supports this control by checking [IsoSpeedControl.Supported](isospeedcontrol_supported.md).

You can access the IsoSpeedControl for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

The IsoSpeedControl enables apps to manage the ISO speed settings on a device. For example, in low-light conditions, apps may prefer higher noise level in return for higher overall brightness. The ISO speed control lets apps adjust tradeoffs such as this.

Use [SetPresetAsync](isospeedcontrol_setpresetasync_1340401685.md) to set the ISO level to one of the [IsoSpeedPreset](isospeedpreset.md) values.

[SupportedPresets](isospeedcontrol_supportedpresets.md) lists the preset values that are support on the device.

For how-to guidance for using the **FocusControl**, see [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture).

## -examples

## -see-also
[Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture)
