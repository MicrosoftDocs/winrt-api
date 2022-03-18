---
-api-id: T:Windows.AI.MachineLearning.TensorFloat
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class TensorFloat : ILearningModelFeatureValue, ITensor
-->

# Windows.AI.MachineLearning.TensorFloat

## -description
A 32-bit float tensor object.

## -remarks
A tensor is a multi-dimensional array of values. A float tensor is a tensor of 32-bit floating point values.

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

For a code example, see [ImageFeatureValue](/uwp/api/windows.ai.machinelearning.imagefeaturevalue). The code example in that topic creates a session and a binding, binds the input image, and then binds the output to a created **TensorFloat**.