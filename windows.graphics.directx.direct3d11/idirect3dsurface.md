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
To move back and forth between IDirect3DSurface and [IDXGISurface](/windows/desktop/api/dxgi/nn-dxgi-idxgisurface), use the [CreateDirect3DSurface](/windows/win32/api/windows.graphics.directx.direct3d11.interop/nf-windows-graphics-directx-direct3d11-interop-createdirect3dsurface) and [GetDXGIInterface(IDirect3DSurface^, DXGI_TYPE**)](/windows/win32/api/d3d11/nf-d3d11-d3d11createdevice) functions.

## -examples

```cppwinrt
// Create a new Windows Console Application (C++/WinRT) project, and
// replace the contents of `pch.h` and `main.cpp` source code files with the code below.
// Be aware that the code below omits the details of obtaining a WinRT Direct3DSurface in
// the first segment of code, and obtaining a native DirectX surface in the second segment.
// The code shows only how to perform the conversion between the two.

// pch.h
#pragma once
#include <d3d11_4.h>
#include <Windows.Graphics.DirectX.Direct3D11.interop.h>
#include <unknwn.h>

#include <winrt/Windows.Foundation.h>
#include <winrt/Windows.Foundation.Collections.h>
#include <winrt/Windows.Graphics.DirectX.Direct3D11.h>

// main.cpp
#include "pch.h"

int main()
{
    winrt::init_apartment();

    // To get the native DirectX surface that is wrapped by a Direct3DSurface.

    winrt::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface d3dSurface /* = ... */;
    winrt::com_ptr<::Windows::Graphics::DirectX::Direct3D11::IDirect3DDxgiInterfaceAccess> dxgiInterfaceAccess{
        d3dSurface.as<::Windows::Graphics::DirectX::Direct3D11::IDirect3DDxgiInterfaceAccess>()
    };
    winrt::com_ptr<::IDXGISurface> nativeSurface;
    winrt::check_hresult(dxgiInterfaceAccess->GetInterface(
        __uuidof(nativeSurface),
        nativeSurface.put_void()));

    // To create a new Direct3DSurface object wrapping a native DirectX surface.

    winrt::com_ptr<::IDXGISurface> nativeSurface2 /* = ... */;
    winrt::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface d3dSurface2{ nullptr };
    winrt::check_hresult(::CreateDirect3D11SurfaceFromDXGISurface(
        nativeSurface2.get(),
        reinterpret_cast<::IInspectable**>(winrt::put_abi(d3dSurface2))));
}
```

```cppcx
// First include the necessary headers and namespaces.
#include <Windows.Graphics.DirectX.Direct3D11.interop.h>
#include <dxgi.h>

using namespace Windows::Graphics::DirectX::Direct3D11;
using namespace Microsoft::WRL;

// To get the native DirectX surface that is wrapped by a Direct3DSurface.

IDirect3DSurface^ d3dSurface = ...;  
ComPtr<IDXGISurface> nativeSurface;

HRESULT hr = GetDXGIInterface(d3dSurface, nativeSurface.GetAddressOf());

// To create a new Direct3DSurface object wrapping a native DirectX surface.

ComPtr<IDXGISurface> nativeSurface = ...;
IDirect3DSurface^ d3dSurface = CreateDirect3DSurface(nativeSurface.Get());
```


## -see-also
[IClosable](../windows.foundation/iclosable.md)
