---
-api-id: M:Windows.Foundation.IMemoryBuffer.CreateReference
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IMemoryBufferReference CreateReference()
-->

# Windows.Foundation.IMemoryBuffer.CreateReference

## -description
Returns a new Windows Runtime object that implements the [IMemoryBufferReference](imemorybufferreference.md) interface.

## -returns
A new Windows Runtime object that implements the [IMemoryBufferReference](imemorybufferreference.md) interface.

## -remarks
This method always successfully returns a new [IMemoryBufferReference](imemorybufferreference.md) object even after the [IMemoryBuffer](imemorybuffer.md) has been closed. In that case, the returned [IMemoryBufferReference](imemorybufferreference.md) is already closed. Therefore, the [IMemoryBufferReference](imemorybufferreference.md) instance's [Capacity](imemorybufferreference_capacity.md) property will be zero and **IMemoryBufferByteAccess::GetBuffer** method will always return a null memory pointer and zero capacity.

## -examples

## -see-also
