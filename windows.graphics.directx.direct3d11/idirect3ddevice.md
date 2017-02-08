---
-api-id: T:Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IDirect3DDevice : Windows.Foundation.IClosable
-->

# Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice

## -description
This represents an [IDXGIDevice](http://msdn.microsoft.com/library/83b24b82-9044-4c99-8d50-63f1e8aef8db) and can be used to interop between Windows Runtime components that need to exchange [IDXGIDevice](http://msdn.microsoft.com/library/83b24b82-9044-4c99-8d50-63f1e8aef8db) references.

## -remarks
To move back and forth between [IDirect3DDevice](direct3ddevice.md) and [IDXGIDevice](http://msdn.microsoft.com/library/83b24b82-9044-4c99-8d50-63f1e8aef8db), use the [CreateDirect3DDevice](createdirect3ddevice.md) and [GetDXGIInterface(IDirect3DDevice^, DXGIType**)](getdxgiinterface.md) functions.

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