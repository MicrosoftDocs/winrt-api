---
-api-id: M:Windows.AI.MachineLearning.TensorInt8Bit.CreateFromBuffer(System.Int64[],Windows.Storage.Streams.IBuffer)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public TensorInt8Bit TensorInt8Bit.CreateFromBuffer(Int64[] shape, IBuffer buffer)
-->

# Windows.AI.MachineLearning.TensorInt8Bit.CreateFromBuffer

## -description
Creates an 8-bit signed integer tensor object with the given *shape* and uses the underlying buffer in *buffer* for subsequent evaluation.

## -parameters
### -param shape
The size of the buffer.

### -param buffer
The buffer to use during evaluation.

## -returns
An 8-bit signed integer tensor object backed by a buffer reference to the provided [IBuffer](../windows.storage.streams/ibuffer.md) *buffer*.

## -remarks
No copies are performed during the creation of this object and the underlying buffer in *buffer* is used directly by the engine.

Copies to video memory are made when running on non-CPU devices.

## -see-also

## -examples

