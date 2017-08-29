---
-api-id: E:Windows.Graphics.Holographic.HolographicSpace.CameraAdded
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler CameraAdded<Windows.Graphics.Holographic.HolographicSpace,  Windows.Graphics.Holographic.HolographicSpaceCameraAddedEventArgs>
-->

# Windows.Graphics.Holographic.HolographicSpace.CameraAdded

## -description
Occurs when a HolographicCamera is added to the current HolographicSpace.

## -remarks
Apps can use this event to set up any per-camera resources they may need.

Unless the deferral is taken, once all event handlers are complete, the system will include this camera in the list of cameras that the app must render to each frame.

If you take a deferral and you've specified the D3D11_CREATE_DEVICE_SINGLETHREADED flag on your device, be sure to explicitly continue any work you spin off on your single Direct3D thread to avoid undefined behavior.

## -examples

## -see-also
