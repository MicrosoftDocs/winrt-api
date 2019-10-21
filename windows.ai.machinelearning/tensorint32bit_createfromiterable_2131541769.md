---
-api-id: M:Windows.AI.MachineLearning.TensorInt32Bit.CreateFromIterable(Windows.Foundation.Collections.IIterable{System.Int64},Windows.Foundation.Collections.IIterable{System.Int32})
-api-type: winrt method
---

<!-- Method syntax.
public TensorInt32Bit TensorInt32Bit.CreateFromIterable(IIterable<Int64> shape, IIterable<Int32> data)
-->

# Windows.AI.MachineLearning.TensorInt32Bit.CreateFromIterable

## -description
Creates a 32-bit signed integer tensor object, allocates a buffer of size *shape*, and copies all of *data* into it.

## -parameters
### -param shape
The size of the buffer.

### -param data
The data to copy into the buffer.

## -returns
A 32-bit signed integer tensor object with a buffer containing the given data.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
