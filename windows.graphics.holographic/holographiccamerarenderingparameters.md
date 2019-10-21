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

Calling this method acquires a buffer that will be used to update the primary layer for the holographic compositor. The buffer remains acquired until the app presents the HolographicFrame used to create the corresponding HolographicCameraRenderingParameters object, at which time the buffer will be committed to the holographic compositor. Apps can have up to two primary layer buffers acquired at any given time. The primary layer buffer format is 8-bit BGRA.

Your app will generally achieve optimal visual quality by calling CommitDirect3D11DepthBuffer to commit an accurate depth buffer whose pixels can be mapped back to meters using your specified near and far planes and then not calling SetFocusPoint.  This enables depth-based stabilization of the holograms in your frame.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | CommitDirect3D11DepthBuffer |
| 1703 | 15063 | ReprojectionMode |
| 1709 | 16299 | IsContentProtectionEnabled |

## -examples

## -see-also

[Depth-based focus plane](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicDepthBasedImageStabilization), [Tag-along hologram sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HolographicTagAlong)
