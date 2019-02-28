---
-api-id: M:Windows.AI.MachineLearning.TensorBoolean.CreateFromArray(Windows.Foundation.Collections.IIterable{System.Int64},System.Boolean[])
-api-type: winrt method
---

<!-- Method syntax.
public TensorBoolean TensorBoolean.CreateFromArray(IIterable<Int64> shape, Boolean[] data)
-->

# Windows.AI.MachineLearning.TensorBoolean.CreateFromArray

## -description
Creates a boolean tensor object, allocates a buffer of size *shape*, and copies all of *data* into it.

## -parameters
### -param shape
The size of the buffer.

### -param data
The data to copy into the buffer.

## -returns
A boolean tensor object with a buffer containing the given data.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
