---
-api-id: M:Windows.Graphics.Imaging.SoftwareBitmap.CreateCopyFromSurfaceAsync(Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.SoftwareBitmap> CreateCopyFromSurfaceAsync(Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface surface)
-->

# Windows.Graphics.Imaging.SoftwareBitmap.CreateCopyFromSurfaceAsync

## -description
Asynchronously creates a new [SoftwareBitmap](softwarebitmap.md) by performing a deep copy of the provided [IDirect3DSurface](../windows.graphics.directx.direct3d11/idirect3dsurface.md). Modifications to the data in the new [SoftwareBitmap](softwarebitmap.md) will not effect the surface from which it was created.

## -parameters
### -param surface
The source surface from which the copy will be created.

## -returns
An asynchronous operation that returns a [SoftwareBitmap](softwarebitmap.md) on successful completion.

## -remarks

## -examples

## -see-also
[CreateCopyFromSurfaceAsync(IDirect3DSurface, BitmapAlphaMode)](softwarebitmap_createcopyfromsurfaceasync_1666076722.md)