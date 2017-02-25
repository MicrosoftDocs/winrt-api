---
-api-id: M:Windows.Graphics.Holographic.HolographicCameraRenderingParameters.CommitDirect3D11DepthBuffer(Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface)
-api-type: winrt method
---

<!-- Method syntax.
public void HolographicCameraRenderingParameters.CommitDirect3D11DepthBuffer(IDirect3DSurface value)
-->

# Windows.Graphics.Holographic.HolographicCameraRenderingParameters.CommitDirect3D11DepthBuffer

## -description
Provides a depth buffer for this frame to the holographic display pipeline, enabling depth-based stabilization of the frame relative to the user's head motion.

## -parameters

### -param value
The Direct3D 11 surface containing the app's depth buffer.

## -remarks
If an app provides a depth buffer for a frame and then skips calling SetFocusPoint, the focus point and normal are inferred based on the depth buffer.

## -see-also

## -examples

