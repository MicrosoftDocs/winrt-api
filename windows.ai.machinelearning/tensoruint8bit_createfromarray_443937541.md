---
-api-id: M:Windows.AI.MachineLearning.TensorUInt8Bit.CreateFromArray(Windows.Foundation.Collections.IIterable{System.Int64},System.Byte[])
-api-type: winrt method
---

<!-- Method syntax.
public TensorUInt8Bit TensorUInt8Bit.CreateFromArray(IIterable<Int64> shape, Byte[] data)
-->

# Windows.AI.MachineLearning.TensorUInt8Bit.CreateFromArray

## -description
Creates an 8-bit unsigned integer tensor object, allocates a buffer of size *shape*, and copies all of *data* into it.

## -parameters
### -param shape
The size of the buffer.

### -param data
The data to copy into the buffer.

## -returns
An 8-bit unsigned integer tensor object with a buffer containing the given data.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
