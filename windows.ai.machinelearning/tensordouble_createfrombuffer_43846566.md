---
-api-id: M:Windows.AI.MachineLearning.TensorDouble.CreateFromBuffer(System.Int64[],Windows.Storage.Streams.IBuffer)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public TensorDouble TensorDouble.CreateFromBuffer(Int64[] shape, IBuffer buffer)
-->

# Windows.AI.MachineLearning.TensorDouble.CreateFromBuffer

## -description
Creates a double tensor object with the given *shape* and uses the underlying buffer in *data* for subsequent evaluation.

## -parameters
### -param shape
The size of the buffer.

### -param buffer
The buffer to use during evaluation.

## -returns
A double tensor object backed by a buffer reference to the provided [IBuffer](../windows.storage.streams/ibuffer.md) *data*.

## -remarks
No copies are performed during the creation of this object and the underlying buffer in *data* is used directly by the engine.

Copies to video memory are made when running on non-CPU devices.

## -see-also

## -examples
