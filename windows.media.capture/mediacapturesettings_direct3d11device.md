---
-api-id: P:Windows.Media.Capture.MediaCaptureSettings.Direct3D11Device
-api-type: winrt property
---

<!-- Property syntax.
public IDirect3DDevice Direct3D11Device { get; }
-->

# Windows.Media.Capture.MediaCaptureSettings.Direct3D11Device

## -description
Gets an [IDirect3DDevice](../windows.graphics.directx.direct3d11/idirect3ddevice.md) representing the Direct3D device instance being used by the associated [MediaCapture](mediacapture.md) object.

## -property-value
An [IDirect3DDevice](../windows.graphics.directx.direct3d11/idirect3ddevice.md) representing the Direct3D device instance being used by the associated [MediaCapture](mediacapture.md) object.

## -remarks
By default, the **MediaCapture** object will attempt to use the GPU for its computation and use Direct3D surfaces to image data, although this can be disabled with the [MemoryPreference](mediacaptureinitializationsettings_memorypreference.md) property. This property allows an app to access the instance of the Direct3D device used to allocate the surfaces. This is particularly useful when interoperating with other Direct3D-based APIs, such as Win2D.

## -see-also

## -examples

