---
-api-id: M:Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.AcquireBufferToUpdateContentWithHardwareProtection
-api-type: winrt method
---

<!-- Method syntax.
public IDirect3DSurface HolographicQuadLayerUpdateParameters.AcquireBufferToUpdateContentWithHardwareProtection()
-->

# Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.AcquireBufferToUpdateContentWithHardwareProtection

## -description
Gets a hardware-protected Direct3D 11 back buffer whose contents will be displayed for this quad layer from this frame forward.

## -returns
The Direct3D 11 surface that holds the hardware-protected back buffer.

## -remarks
This method acquires a hardware-protected buffer that will be used to update the quad layer. Applications must acquire a new buffer each time they need to change the texture. Avoid calling this method if you do not need to update the texture.

This method call will fail unless [CanAcquireWithHardwareProtection](holographicquadlayerupdateparameters_canacquirewithhardwareprotection.md) returns true.

To avoid repeated texture load costs, applications may load a single quad layer buffer containing a texture atlas and then call [UpdateViewport](holographicquadlayerupdateparameters_updateviewport_1003624236.md) to select a subset rectangle within the texture to display.

This method will make use of the Direct3D device you provided to the [HolographicSpace](holographicspace.md).  If you've specified the [D3D11_CREATE_DEVICE_SINGLETHREADED](/windows/desktop/api/d3d11/ne-d3d11-d3d11_create_device_flag) flag on your device, be sure to call this method from your single Direct3D thread to avoid undefined behavior.

To enable hardware content protection for the primary layer's buffer, set [HolographicCamera.IsHardwareContentProtectionEnabled](holographiccamera_ishardwarecontentprotectionenabled.md) to true.

> [!NOTE]
> This method must be called when updating a [HolographicQuadLayer](holographicquadlayer.md) object for the first time.

## -see-also

## -examples

