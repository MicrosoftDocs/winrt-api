---
-api-id: M:Windows.Media.VideoFrame.CreateWithDirect3D11Surface(Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface)
-api-type: winrt method
---

<!-- Method syntax.
public VideoFrame VideoFrame.CreateWithDirect3D11Surface(IDirect3DSurface surface)
-->

# Windows.Media.VideoFrame.CreateWithDirect3D11Surface

## -description
Creates a new instance of the [VideoFrame](videoframe.md) class for which the image data is stored in the provided [IDXGISurface](/windows/desktop/api/dxgi/nn-dxgi-idxgisurface).

## -parameters
### -param surface
The [IDXGISurface](/windows/desktop/api/dxgi/nn-dxgi-idxgisurface) in which the image data is stored.

## -returns
A **VideoFrame**.

## -remarks
If the *surface* parameter is null, an argument exception will occur. The supplied [IDXGISurface](/windows/desktop/api/dxgi/nn-dxgi-idxgisurface) must use one of the supported pixel formats. **VideoFrame** supports the formats corresponding to the following [DirectXPixelFormat](../windows.graphics.directx/directxpixelformat.md) values:

* **DirectXPixelFormat_R16G16B16A16UIntNormalized** 
* **DirectXPixelFormat_R8G8B8A8UIntNormalized**
* **DirectXPixelFormat_B8G8R8X8UIntNormalized** 
* **DirectXPixelFormat_B8G8R8A8UIntNormalized** 
* **DirectXPixelFormat_NV12**
* **DirectXPixelFormat_P010** 
* **DirectXPixelFormat_Yuy2** 
* **DirectXPixelFormat_R16UIntNormalized** 
* **DirectXPixelFormat_R8UIntNormalized** 

All other formats are unsupported. If a surface with an unsupported format is specified, a COM exception will be thrown.

## -see-also

## -examples

