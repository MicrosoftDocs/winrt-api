---
-api-id: T:Windows.AI.MachineLearning.TensorString
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class TensorString : ILearningModelFeatureValue, ITensor
-->

# Windows.AI.MachineLearning.TensorString

## -description
A string tensor object.

## -remarks
A tensor is a multi-dimensional array of values. A string tensor is a tensor of string values.

The layout of tensors is row-major, with tightly packed contiguous data representing each dimension. The total size of a tensor is the product of the size of each dimension.

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | CreateFromShapeArrayAndDataArray |

## -see-also
[Windows ML](/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples
