---
-api-id: T:Windows.Media.Devices.FocusControl
-api-type: winrt class
---

<!-- Class syntax.
public class FocusControl : Windows.Media.Devices.IFocusControl, Windows.Media.Devices.IFocusControl2
-->

# Windows.Media.Devices.FocusControl

## -description
Provides functionality for controlling the focus settings on a capture device.

## -remarks
You can find out if a device supports this control by checking [FocusControl.Supported](focuscontrol_supported.md).

If the device does not support the FocusControl, you can still use the [Focus](videodevicecontroller_focus.md) property on the [VideoCaptureDevice](https://msdn.microsoft.com/library/afba2768-11a0-4105-a5b1-c48bc961e9ed) to set the focus value.

You can access the FocusControl for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

The FocusControl gives apps additional control over the focus settings on a device.

You can use one of the [FocusPreset](focuspreset.md) values by calling [SetPresetAsync](focuscontrol_setpresetasync_183048954.md). Or call [SetValueAsync](focuscontrol_setvalueasync_2096210171.md) to set a specific [Value](focuscontrol_value.md) between the [Min](focuscontrol_min.md) and [Max](focuscontrol_max.md).

For how-to guidance for using the **FocusControl**, see [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture).

## -examples

## -see-also
[MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md), [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture)
