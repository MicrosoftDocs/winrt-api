---
-api-id: M:Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.AcquireBufferToUpdateContent
-api-type: winrt method
---

<!-- Method syntax.
public IDirect3DSurface HolographicQuadLayerUpdateParameters.AcquireBufferToUpdateContent()
-->

# Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.AcquireBufferToUpdateContent

## -description
Gets a Direct3D 11 back buffer whose contents will be displayed for this quad layer from this frame forward.

## -returns
The Direct3D 11 surface that holds the back buffer.

## -remarks
This method acquires a buffer that will be used to update the quad layer. Apps must acquire a new buffer each time they need to change the texture. Avoid calling this method if you do not need to update the texture.

To avoid repeated texture load costs, apps may load a single quad layer buffer containing a texture atlas and then call [UpdateViewport](holographicquadlayerupdateparameters_updateviewport_1003624236.md) to select a subset rectangle within the texture to display.

This method will make use of the Direct3D device you provided to the HolographicSpace.  If you've specified the D3D11_CREATE_DEVICE_SINGLETHREADED flag on your device, be sure to call this method from your single Direct3D thread to avoid undefined behavior.

**Note:** This method must be called when updating a HolographicQuadLayer object for the first time.

## -see-also

## -examples

