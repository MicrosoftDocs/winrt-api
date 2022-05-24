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

You should only use the shutter state data represented by this class while the camera is actively streaming. Apps should respond in a logical manner when they detect that the shutter is closed. This should include an in-app message to open the shutter. Applications must not automatically take an action (e.g., turn the camera off) or block the user from doing an action (e.g., turning on the camera) based on the shutter state, as not every camera will reliably report the shutter state when not streaming. Applications must not treat the reported shutter state as an absolute privacy indicator – it is only a notification that the camera believes the shutter is closed.

## -see-also

[VideoDeviceController](videodevicecontroller.md)

## -examples


