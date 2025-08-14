---
-api-id: M:Windows.AI.MachineLearning.TensorInt8Bit.Create(Windows.Foundation.Collections.IIterable{System.Int64})
-api-type: winrt method
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Method syntax.
public TensorInt8Bit TensorInt8Bit.Create(IIterable<Int64> shape)
-->

# Windows.AI.MachineLearning.TensorInt8Bit.Create

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Creates an 8-bit signed integer tensor object and allocates a buffer of size *shape*.

## -parameters
### -param shape
The size of the buffer.

## -returns
An 8-bit signed integer tensor object with a buffer of the given size.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
