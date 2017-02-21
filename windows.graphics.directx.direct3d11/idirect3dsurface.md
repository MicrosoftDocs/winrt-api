---
-api-id: T:Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IDirect3DSurface : Windows.Foundation.IClosable
-->

# Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface

## -description
This represents an [IDXGISurface](https://msdn.microsoft.com/en-us/library/windows/desktop/bb174565) and can be used to interop between Windows Runtime components that need to exchange [IDXGISurface](https://msdn.microsoft.com/en-us/library/windows/desktop/bb174565) references.

## -remarks
To move back and forth between [IDirect3DSurface](idirect3dsurface.md) and [IDXGISurface](https://msdn.microsoft.com/en-us/library/windows/desktop/bb174565), use the [CreateDirect3DSurface](https://msdn.microsoft.com/en-us/library/windows/apps/dn895090) and [GetDXGIInterface(IDirect3DSurface^, DXGIType**)](https://msdn.microsoft.com/en-us/library/windows/apps/dn895102) functions.

## -examples
First include the necessary headers and namespaces:

```cpp
#include <Windows.Graphics.DirectX.Direct3D11.interop.h>
#include <dxgi.h>
using namespace Windows::Graphics::DirectX::Direct3D11;
using namespace Microsoft::WRL;
```

To get the native DirectX surface that is wrapped by a Direct3DSurface:

```cpp
IDirect3DSurface^ d3dSurface = ...;  
ComPtr<IDXGISurface> nativeSurface;
HRESULT hr = GetDXGIInterface(d3dSurface, nativeSurface.GetAddressOf());
```

To create a new Direct3DSurface object wrapping a native DirectX surface:

```cpp
ComPtr<IDXGISurface> nativeSurface = ...;
IDirect3DSurface^ d3dSurface = CreateDirect3DSurface(nativeSurface.Get());

```



## -see-also
[IClosable](../windows.foundation/iclosable.md)