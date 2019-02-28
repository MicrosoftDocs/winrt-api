---
-api-id: M:Windows.AI.MachineLearning.TensorDouble.CreateFromArray(Windows.Foundation.Collections.IIterable{System.Int64},System.Double[])
-api-type: winrt method
---

<!-- Method syntax.
public TensorDouble TensorDouble.CreateFromArray(IIterable<Int64> shape, Double[] data)
-->

# Windows.AI.MachineLearning.TensorDouble.CreateFromArray

## -description
Creates a 64-bit float tensor object, allocates a buffer of size *shape*, and copies all of *data* into it.

## -parameters
### -param shape
The size of the buffer.

### -param data
The data to copy into the buffer.

## -returns
A 64-bit float tensor object with a buffer containing the given data.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
