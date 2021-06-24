---
-api-id: T:Windows.Media.Devices.CameraOcclusionInfo
-api-type: winrt class
---

# Windows.Media.Devices.CameraOcclusionInfo

<!--
public sealed class CameraOcclusionInfo
-->


## -description

Provides information about the occlusion state of a camera device.

## -remarks

Many devices provide mechanisms, such as a mechanical shutter, that allow the user to occlude the camera device for privacy. Other devices may occlude the camera in certain postures. This interface allows applications to receive notifications when the occlusion state of the camera changes so they can disable or modify their camera capture behavior when the camera is occluded.

Get an instance of this class by accessing the [CameraOcclusionInfo](videodevicecontroller_cameraocclusioninfo.md) property of the [VideoDeviceController](videodevicecontroller.md) associated with the camera.

## -see-also

[VideoDeviceController](videodevicecontroller.md)

## -examples


