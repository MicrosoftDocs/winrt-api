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

## -remarks
To move back and forth between IDirect3DDevice and [IDXGIDevice](/windows/desktop/api/dxgi/nn-dxgi-idxgidevice), use the [CreateDirect3DDevice](https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-d3d11createdevice) and [GetDXGIInterface(IDirect3DDevice^, DXGI_TYPE**)](https://docs.microsoft.com/windows/desktop/api/d3d11/nf-d3d11-d3d11createdevice) functions.

## -examples
First include the necessary headers and namespaces.

```cppcx
#include <Windows.Graphics.DirectX.Direct3D11.interop.h>
#include <dxgi.h>

using namespace Windows::Graphics::DirectX::Direct3D11;
using namespace Microsoft::WRL;
```

To get the native DirectX device that is wrapped by a Direct3DDevice.

```cppcx
IDirect3DDevice^ d3dDevice = ...;  
ComPtr<IDXGIDevice> nativeDevice;

HRESULT hr = GetDXGIInterface(d3dDevice, nativeDevice.GetAddressOf());
```

To create a new Direct3DDevice object wrapping a native DirectX device.

```cppcx
ComPtr<IDXGIDevice> nativeDevice = ...;
IDirect3DDevice^ winRTDevice = CreateDirect3DDevice(nativeDevice.Get());
```

## -see-also
[IClosable](../windows.foundation/iclosable.md)
