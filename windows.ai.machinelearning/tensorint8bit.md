---
-api-id: T:Windows.AI.MachineLearning.TensorInt8Bit
-api-type: winrt class
ms.custom: RS5
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Class syntax.
public class TensorInt8Bit : ILearningModelFeatureValue, ITensor
-->

# Windows.AI.MachineLearning.TensorInt8Bit

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

An 8-bit signed integer tensor object.

## -remarks
A tensor is a multi-dimensional array of values. An 8-bit signed integer tensor is a tensor of 8-bit signed integer values.

The layout of tensors is row-major, with tightly packed contiguous data representing each dimension. The total size of a tensor is the product of the size of each dimension.

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | CreateFromBuffer |
| 1903 | 18362 | CreateFromShapeArrayAndDataArray |

## -see-also
[Windows ML](/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples
