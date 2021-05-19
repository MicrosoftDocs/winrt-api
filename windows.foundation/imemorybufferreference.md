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
The IMemoryBufferReference interface allows a client to retrieve the [Capacity](imemorybufferreference_capacity.md) of the memory buffer. The same object identity must also implement the COM interface [IMemoryBufferByteAccess](https://docs.microsoft.com/en-us/previous-versions/mt297505(v=vs.85)). A client retrieves the [IMemoryBufferByteAccess](https://docs.microsoft.com/en-us/previous-versions/mt297505(v=vs.85)) interface pointer via a **QueryInterface** from the IMemoryBufferReference object.

## -examples

## -see-also
[IClosable](iclosable.md)
