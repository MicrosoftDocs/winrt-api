---
-api-id: T:Windows.Graphics.Holographic.HolographicCameraRenderingParameters
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class HolographicCameraRenderingParameters : Windows.Graphics.Holographic.IHolographicCameraRenderingParameters, Windows.Graphics.Holographic.Preview.IHolographicCameraRenderingParameters2
-->

# Windows.Graphics.Holographic.HolographicCameraRenderingParameters

## -description
Represents per-camera parameters for rendering holographic content.

## -remarks
An app can call the SetFocusPoint method each frame to improve holographic image quality. The app can specify the position, normal, and velocity of the user's likely focus point within the scene. Holograms will be most stable both at the specified position, and along the plane defined by that position and the normal. If the content does not have an obvious normal, omit it or have it face the user.

## -examples

## -see-also
