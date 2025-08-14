---
-api-id: M:Windows.AI.MachineLearning.TensorUInt8Bit.CreateFromIterable(Windows.Foundation.Collections.IIterable{System.Int64},Windows.Foundation.Collections.IIterable{System.Byte})
-api-type: winrt method
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Method syntax.
public TensorUInt8Bit TensorUInt8Bit.CreateFromIterable(IIterable<Int64> shape, IIterable<Byte> data)
-->

# Windows.AI.MachineLearning.TensorUInt8Bit.CreateFromIterable

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

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
