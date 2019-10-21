---
-api-id: T:Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface
-api-type: winrt interface
ms.custom: 19H1
---

<!-- Interface syntax.
public interface IDirect3DSurface : Windows.Foundation.IClosable
-->

# Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface

## -description
This represents an [IDXGISurface](/windows/desktop/api/dxgi/nn-dxgi-idxgisurface) and can be used to interop between Windows Runtime components that need to exchange **IDXGISurface** references.

## -remarks
To move back and forth between IDirect3DSurface and [IDXGISurface](/windows/desktop/api/dxgi/nn-dxgi-idxgisurface), use the [CreateDirect3DSurface](https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-d3d11createdevice) and [GetDXGIInterface(IDirect3DSurface^, DXGI_TYPE**)](https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-d3d11createdevice) functions.

## -examples
First include the necessary headers and namespaces.

```cppcx
#include <Windows.Graphics.DirectX.Direct3D11.interop.h>
#include <dxgi.h>

using namespace Windows::Graphics::DirectX::Direct3D11;
using namespace Microsoft::WRL;
```

To get the native DirectX surface that is wrapped by a Direct3DSurface.

```cppcx
IDirect3DSurface^ d3dSurface = ...;  
ComPtr<IDXGISurface> nativeSurface;

HRESULT hr = GetDXGIInterface(d3dSurface, nativeSurface.GetAddressOf());
```

To create a new Direct3DSurface object wrapping a native DirectX surface.

```cppcx
ComPtr<IDXGISurface> nativeSurface = ...;
IDirect3DSurface^ d3dSurface = CreateDirect3DSurface(nativeSurface.Get());
```

## -see-also
[IClosable](../windows.foundation/iclosable.md)
