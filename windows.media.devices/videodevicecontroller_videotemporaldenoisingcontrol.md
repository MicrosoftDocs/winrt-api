---
-api-id: P:Windows.Media.Devices.VideoDeviceController.VideoTemporalDenoisingControl
-api-type: winrt property
---

<!-- Property syntax.
public VideoTemporalDenoisingControl VideoTemporalDenoisingControl { get; }
-->

# Windows.Media.Devices.VideoDeviceController.VideoTemporalDenoisingControl

## -description
Gets the [VideoTemporalDenoisingControl](videotemporaldenoisingcontrol.md) associated with the [VideoDeviceController](videodevicecontroller.md). This allows you to enable and disable temporal denoising, which uses image data from adjacent frames to reduce the appearance of noise in captured video, on devices that support it.

## -property-value
The [VideoTemporalDenoisingControl](videotemporaldenoisingcontrol.md) associated with the [VideoDeviceController](videodevicecontroller.md).

## -remarks
Temporal denoising can improve the visual quality of video to the human eye, but it also can reduce image consistency and details which can negatively impact the performance of registration, optical character recognition, and other computer vision tasks. This control allows you to enable and disable the feature depending on your app's current video capture scenario.

## -see-also
[VideoTemporalDenoisingControl](videotemporaldenoisingcontrol.md)

## -examples

