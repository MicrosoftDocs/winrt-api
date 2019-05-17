---
-api-id: T:Windows.Media.Devices.SceneModeControl
-api-type: winrt class
---

<!-- Class syntax.
public class SceneModeControl : Windows.Media.Devices.ISceneModeControl
-->

# Windows.Media.Devices.SceneModeControl

## -description
Provides functionality for controlling the scene mode settings on a capture device.

## -remarks
The [SceneModeControl  enables apps to tune the post-processing of captured frames to better match the scene being recorded. The [SupportedModes](scenemodecontrol_supportedmodes.md) enumeration specifies the modes, such as [Snow](capturescenemode.md), [Night](capturescenemode.md), and [Sport](capturescenemode.md), that are supported by the device.

To select a mode, call [SceneModeControl.SetValueAsync](scenemodecontrol_setvalueasync_1270895798.md).

You can access the [SceneModeControl  for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

## -examples

## -see-also
[MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md)
