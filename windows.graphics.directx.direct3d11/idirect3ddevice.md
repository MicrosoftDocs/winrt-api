---
-api-id: T:Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IDirect3DDevice : Windows.Foundation.IClosable
-->

# Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice

## -description
This represents an [IDXGIDevice](https://msdn.microsoft.com/en-us/library/windows/desktop/bb174527) and can be used to interop between Windows Runtime components that need to exchange [IDXGIDevice](https://msdn.microsoft.com/en-us/library/windows/desktop/bb174527) references.

## -remarks
To move back and forth between [IDirect3DDevice](idirect3ddevice.md) and [IDXGIDevice](https://msdn.microsoft.com/en-us/library/windows/desktop/bb174527), use the [CreateDirect3DDevice](https://msdn.microsoft.com/en-us/library/windows/apps/dn895089) and [GetDXGIInterface(IDirect3DDevice^, DXGIType**)](https://msdn.microsoft.com/en-us/library/windows/apps/dn895100) functions.

## -examples
First include the necessary headers and namespaces:

```cpp
#include <Windows.Graphics.DirectX.Direct3D11.interop.h>
#include <dxgi.h>

using namespace Windows::Graphics::DirectX::Direct3D11;
using namespace Microsoft::WRL;
```

To get the native DirectX device that is wrapped by a Direct3DDevice:

```cpp
IDirect3DDevice^ d3dDevice = ...;  
ComPtr<IDXGIDevice> nativeDevice;

HRESULT hr = GetDXGIInterface(d3dDevice, nativeDevice.GetAddressOf());
```

To create a new Direct3DDevice object wrapping a native DirectX device:

```cpp
ComPtr<IDXGIDevice> nativeDevice = ...;
IDirect3DDevice^ winRTDevice = CreateDirect3DDevice(nativeDevice.Get());

```



## -see-also
[IClosable](../windows.foundation/iclosable.md)