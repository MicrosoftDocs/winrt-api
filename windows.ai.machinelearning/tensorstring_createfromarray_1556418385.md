---
-api-id: M:Windows.AI.MachineLearning.TensorString.CreateFromArray(Windows.Foundation.Collections.IIterable{System.Int64},System.String[])
-api-type: winrt method
---

<!-- Method syntax.
public TensorString TensorString.CreateFromArray(IIterable<Int64> shape, String[] data)
-->

# Windows.AI.MachineLearning.TensorString.CreateFromArray

## -description
Creates a string tensor object, allocates a buffer of size *shape*, and copies all of *data* into it.

## -parameters
### -param shape
The size of the buffer.

### -param data
The data to copy into the buffer.

## -returns
A string tensor object with a buffer containing the given data.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
