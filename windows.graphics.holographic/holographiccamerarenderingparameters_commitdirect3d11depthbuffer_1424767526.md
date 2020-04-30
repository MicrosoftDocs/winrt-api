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
If an app provides a depth buffer for a frame and then skips calling SetFocusPoint, the focus point and normal are inferred based on the depth buffer.  Your app will generally achieve optimal visual quality by committing an accurate depth buffer whose pixels can be mapped back to meters using your specified near and far planes and then not calling SetFocusPoint.

This method will make use of the Direct3D device you provided to the HolographicSpace.  If you've specified the D3D11_CREATE_DEVICE_SINGLETHREADED flag on your device, be sure to call this method from your single Direct3D thread to avoid undefined behavior.

The following code example shows how to convert a depth buffer resource from a native [ID3D11Texture2D](/windows/win32/api/d3d11/nn-d3d11-id3d11texture2d) to a WinRT [IDirect3DSurface](/uwp/api/windows.graphics.directx.direct3d11.idirect3dsurface) interface that can be passed into **CommitDirect3D11DepthBuffer**. The **ID3D11Texture2D** must have been created with the [D3D11_BIND_SHADER_RESOURCE](/windows/win32/api/d3d11/ne-d3d11-d3d11_bind_flag) to be read by the system.

```cppwinrt
inline winrt::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface CreateDepthTextureInteropObject(
        const Microsoft::WRL::ComPtr<ID3D11Texture2D> spTexture2D)
{
    // Direct3D interop APIs are used to provide the buffer to the WinRT API.
    Microsoft::WRL::ComPtr<IDXGIResource1> depthStencilResource;
    winrt::check_hresult(spTexture2D.As(&depthStencilResource));
    Microsoft::WRL::ComPtr<IDXGISurface2> depthDxgiSurface;
    winrt::check_hresult(depthStencilResource->CreateSubresourceSurface(0, &depthDxgiSurface));
    winrt::com_ptr<::IInspectable> inspectableSurface;
    winrt::check_hresult(
        CreateDirect3D11SurfaceFromDXGISurface(
            depthDxgiSurface.Get(),
            reinterpret_cast<IInspectable**>(winrt::put_abi(inspectableSurface))
        ));

    return inspectableSurface.as<winrt::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface>();
}
```

The **CreateDepthTextureInteropObject** method shown in this example is included in the [Windows Mixed Reality App templates](https://marketplace.visualstudio.com/items?itemName=WindowsMixedRealityteam.WindowsMixedRealityAppTemplatesVSIX).

## -see-also

## -examples

