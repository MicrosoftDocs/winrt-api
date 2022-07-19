---
-api-id: T:Windows.Foundation.MemoryBuffer
-api-type: winrt class
---

<!-- Class syntax.
public class MemoryBuffer : Windows.Foundation.IClosable, Windows.Foundation.IMemoryBuffer
-->

# Windows.Foundation.MemoryBuffer

## -description
Represents a reference counted memory buffer.

## -remarks

This type also implements the COM interface [**IMemoryBufferByteAccess**](/windows/win32/winrt/imemorybufferbyteaccess-getbuffer), which provides direct access to the buffer's storage. See the [Custom Effect sample](https://github.com/microsoft/Windows-universal-samples/blob/main/Samples/AudioCreation/cs/CustomEffect/CustomEffect.cs) for a C# example on how to access the buffer.

> [!NOTE]
> C++/WinRT provides extension methods on `MemoryBuffer` to access the data directly. Various languages and runtimes provide unique ways to access process memory. Be careful when accessing the buffer as the lifecycle of the memory is related to the lifecycle of the `IMemoryBufferByteAccess` interface.

## -examples

## -see-also
[IMemoryBuffer](imemorybuffer.md), [IClosable](iclosable.md), [IMemoryBufferByteAccess](/windows/win32/winrt/imemorybufferbyteaccess-getbuffer)
