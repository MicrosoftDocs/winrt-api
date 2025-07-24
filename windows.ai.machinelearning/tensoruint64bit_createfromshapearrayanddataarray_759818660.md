---
-api-id: M:Windows.AI.MachineLearning.TensorUInt64Bit.CreateFromShapeArrayAndDataArray(System.Int64[],System.UInt64[])
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public TensorUInt64Bit TensorUInt64Bit.CreateFromShapeArrayAndDataArray(Int64[] shape, UInt64[] data)
-->

# Windows.AI.MachineLearning.TensorUInt64Bit.CreateFromShapeArrayAndDataArray

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Creates a 64-bit unsigned integer tensor object, allocates a buffer of size *shape*, and copies all of *data* into it.

## -parameters
### -param shape
The size of the buffer.

### -param data
The data to be copied into the buffer.

## -returns
A 64-bit unsigned integer tensor object with a buffer containing the given data.

## -remarks

## -see-also

## -examples
