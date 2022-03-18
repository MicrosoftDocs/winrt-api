---
-api-id: M:Windows.Media.VideoFrame.CreateAsDirect3D11SurfaceBacked(Windows.Graphics.DirectX.DirectXPixelFormat,System.Int32,System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public VideoFrame VideoFrame.CreateAsDirect3D11SurfaceBacked(DirectXPixelFormat format, Int32 width, Int32 height)
-->

# Windows.Media.VideoFrame.CreateAsDirect3D11SurfaceBacked

## -description
Creates a new instance of the [VideoFrame](videoframe.md) class for which the image data is stored in an [IDXGISurface](/windows/desktop/api/dxgi/nn-dxgi-idxgisurface) allocated by the default Direct3D device.

## -parameters
### -param format
A value from the [DirectXPixelFormat](../windows.graphics.directx/directxpixelformat.md) enumeration, specifying the pixel format of the created **VideoFrame**. Not all pixel formats are supported. See the Remarks section for more information. 

### -param width
The width, in pixels, of the created **VideoFrame**.

### -param height
The height, in pixels, of the created **VideoFrame**.

## -returns
A **VideoFrame**.

## -remarks

The following pixel formats, defined in the [DirectXPixelFormat](../windows.graphics.directx/directxpixelformat.md) enumeration, are supported by **VideoFrame**. 

* **DirectXPixelFormat_R16G16B16A16UIntNormalized** 
* **DirectXPixelFormat_R8G8B8A8UIntNormalized**
* **DirectXPixelFormat_B8G8R8X8UIntNormalized** 
* **DirectXPixelFormat_B8G8R8A8UIntNormalized** 
* **DirectXPixelFormat_NV12**
* **DirectXPixelFormat_P010** 
* **DirectXPixelFormat_Yuy2** 
* **DirectXPixelFormat_R16UIntNormalized** 
* **DirectXPixelFormat_R8UIntNormalized** 

All other formats are unsupported. Attempting to create a **VideoFrame** with an unsupported format will cause the method to fail with a COM exception. 

The overload of this method, [CreateAsDirect3D11SurfaceBacked](videoframe_createasdirect3d11surfacebacked_857687066.md), allows you to supply the [IDirect3DDevice](../windows.graphics.directx.direct3d11/idirect3ddevice.md) that is used to allocate the backing surface of the video frame.

## -see-also

## -examples

