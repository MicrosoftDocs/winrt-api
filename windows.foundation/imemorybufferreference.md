---
-api-id: T:Windows.Foundation.IMemoryBufferReference
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IMemoryBufferReference : Windows.Foundation.IClosable
-->

# Windows.Foundation.IMemoryBufferReference

## -description
Represents a reference to an [IMemoryBuffer](imemorybuffer.md) object.

## -remarks
The IMemoryBufferReference interface allows a client to retrieve the [Capacity](imemorybufferreference_capacity.md) of the memory buffer. The same object identity must also implement the COM interface [IMemoryBufferByteAccess](/previous-versions/mt297505(v=vs.85)). A client retrieves the [IMemoryBufferByteAccess](/previous-versions/mt297505(v=vs.85)) interface pointer via a **QueryInterface** from the IMemoryBufferReference object.

### C++/WinRT extension functions

> [!NOTE]
> Extension functions exist on the C++/WinRT projection types for certain Windows Runtime APIs. For example, **winrt::Windows::Foundation::IAsyncAction** is the C++/WinRT projection type for [IAsyncAction](/uwp/api/windows.foundation.iasyncaction). The extension functions aren't part of the application binary interface (ABI) surface of the actual Windows Runtime types, so they're not listed as members of the Windows Runtime APIs. But you can call them from within any C++/WinRT project. See [C++/WinRT functions that extend Windows Runtime APIs](/uwp/cpp-ref-for-winrt/winrt#cwinrt-functions-that-extend-windows-runtime-apis).

```cppwinrt
uint8_t* data() const;
```

Returns a pointer to the data held inside the buffer.

## -examples

## -see-also
[IClosable](iclosable.md)
