---
-api-id: T:Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice
-api-type: winrt interface
ms.custom: 19H1
---

<!-- Interface syntax.
public interface IDirect3DDevice : Windows.Foundation.IClosable
-->

# Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice

## -description
This represents an [IDXGIDevice](/windows/desktop/api/dxgi/nn-dxgi-idxgidevice), and can be used to interop between Windows Runtime components that need to exchange **IDXGIDevice** references.

## -examples

```cppwinrt
// Create a new Windows Console Application (C++/WinRT) project, and
// replace the contents of `pch.h` and `main.cpp` source code files with the code below.
// Be aware that the code below omits the details of obtaining a WinRT Direct3DDevice in
// the first segment of code, and obtaining a native DirectX device in the second segment.
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

    // To get the native DirectX device that is wrapped by a Direct3DDevice.

    winrt::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice d3dDevice /* = ... */;
    winrt::com_ptr<::Windows::Graphics::DirectX::Direct3D11::IDirect3DDxgiInterfaceAccess> dxgiInterfaceAccess{
        d3dDevice.as<::Windows::Graphics::DirectX::Direct3D11::IDirect3DDxgiInterfaceAccess>()
    };
    winrt::com_ptr<::IDXGIDevice> nativeDevice;
    winrt::check_hresult(dxgiInterfaceAccess->GetInterface(
        __uuidof(nativeDevice),
        nativeDevice.put_void()));

    // To create a new Direct3DDevice object wrapping a native DirectX device.

    winrt::com_ptr<::IDXGIDevice> nativeDevice2 /* = ... */;
    winrt::Windows::Graphics::DirectX::Direct3D11::IDirect3DDevice d3dDevice2{ nullptr };
    winrt::check_hresult(::CreateDirect3D11DeviceFromDXGIDevice(
        nativeDevice2.get(),
        reinterpret_cast<::IInspectable**>(winrt::put_abi(d3dDevice2))));
}
```

```cppcx
// First include the necessary headers and namespaces.
#include <Windows.Graphics.DirectX.Direct3D11.interop.h>
#include <dxgi.h>

using namespace Windows::Graphics::DirectX::Direct3D11;
using namespace Microsoft::WRL;

// To get the native DirectX device that is wrapped by a Direct3DDevice.

IDirect3DDevice^ d3dDevice = ...;  
ComPtr<IDXGIDevice> nativeDevice;

HRESULT hr = GetDXGIInterface(d3dDevice, nativeDevice.GetAddressOf());

// To create a new Direct3DDevice object wrapping a native DirectX device.

ComPtr<IDXGIDevice> nativeDevice = ...;
IDirect3DDevice^ winRTDevice = CreateDirect3DDevice(nativeDevice.Get());
```

## -remarks

If you're using C++/WinRT, then to move back and forth between **IDirect3DDevice** and [IDXGIDevice](/windows/desktop/api/dxgi/nn-dxgi-idxgidevice), use the [IDirect3DDxgiInterfaceAccess::GetInterface](/windows/win32/api/windows.graphics.directx.direct3d11.interop/nf-windows-graphics-directx-direct3d11-interop-idirect3ddxgiinterfaceaccess-getinterface) and [CreateDirect3D11DeviceFromDXGIDevice](/windows/win32/api/windows.graphics.directx.direct3d11.interop/nf-windows-graphics-directx-direct3d11-interop-createdirect3d11devicefromdxgidevice) functions. You can see another code example in [Composition native interoperation with DirectX and Direct2D](/windows/uwp/composition/composition-native-interop).

If you're using C++/CX, then to move back and forth between **IDirect3DDevice** and [IDXGIDevice](/windows/desktop/api/dxgi/nn-dxgi-idxgidevice), use the [CreateDirect3DDevice](/windows/win32/api/windows.graphics.directx.direct3d11.interop/nf-windows-graphics-directx-direct3d11-interop-createdirect3ddevice) and [GetDXGIInterface(IDirect3DDevice^, DXGI_TYPE**)](/windows/win32/api/windows.graphics.directx.direct3d11.interop/nf-windows-graphics-directx-direct3d11-interop-getdxgiinterface) functions.

## -see-also

[IClosable](../windows.foundation/iclosable.md)
