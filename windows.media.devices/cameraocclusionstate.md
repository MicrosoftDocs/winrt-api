---
-api-id: T:Windows.Media.Devices.CameraOcclusionState
-api-type: winrt class
---

# Windows.Media.Devices.CameraOcclusionState

<!--
public sealed class CameraOcclusionState
-->


## -description

Represents the occlusion state of a camera device.

## -remarks

Get an instance of this class by implementing a handler for the [CameraOcclusionInfo.StateChanged](cameraocclusioninfo_statechanged.md) event and accessing the [State](cameraocclusionstatechangedeventargs_state.md) property of the [CameraOcclusionStateChangedEventArgs](cameraocclusionstatechangedeventargs.md).

You should only use the shutter state data represented by this class while the camera is actively streaming. Apps should respond in a logical manner when they detect that the shutter is closed. This should include an in-app message to open the shutter. Applications must not automatically take an action (e.g., turning the camera off) or block the user from doing an action (e.g., turning on the camera) based on the shutter state, as not every camera will reliably report the shutter state when not streaming. Applications must not treat the reported shutter state as an absolute privacy indicator – it is only a notification that the camera believes the shutter is closed.

## -see-also

[CameraOcclusionInfo.StateChanged](cameraocclusioninfo_statechanged.md), [CameraOcclusionStateChangedEventArgs](cameraocclusionstatechangedeventargs.md) 

## -examples


