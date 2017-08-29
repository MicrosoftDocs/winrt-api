---
-api-id: E:Windows.Graphics.Holographic.HolographicSpace.CameraRemoved
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler CameraRemoved<Windows.Graphics.Holographic.HolographicSpace,  Windows.Graphics.Holographic.HolographicSpaceCameraRemovedEventArgs>
-->

# Windows.Graphics.Holographic.HolographicSpace.CameraRemoved

## -description
Occurs when a HolographicCamera is removed from the current HolographicSpace.

## -remarks
Apps can use this event to tear down any per-camera resources they may have set up during CameraAdded.

The system will no longer require that the app render to this camera, starting in the next frame after this event.

If you take a deferral and you've specified the D3D11_CREATE_DEVICE_SINGLETHREADED flag on your device, be sure to explicitly continue any work you spin off on your single Direct3D thread to avoid undefined behavior.

## -examples

## -see-also
