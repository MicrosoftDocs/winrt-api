---
-api-id: M:Windows.Graphics.Holographic.HolographicSpace.SetDirect3D11Device(Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetDirect3D11Device(Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice value)
-->

# Windows.Graphics.Holographic.HolographicSpace.SetDirect3D11Device

## -description
Assigns the IDirect3DDevice that will display holographic content. An error will occur if the app creates an inappropriate device.

## -parameters
### -param value
The Direct3D device.

## -remarks
This method will make use of the Direct3D device you provide to set up holographic rendering.  If you've specified the D3D11_CREATE_DEVICE_SINGLETHREADED flag on your device, be sure to call this method from your single Direct3D thread to avoid undefined behavior.

This method should be called when providing the Direct3D device for the first time, and when the Direct3D device has changed.

## -examples

## -see-also
