---
-api-id: T:Windows.AI.MachineLearning.LearningModelFeatureKind
-api-type: winrt enum
ms.custom: RS5
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Enumeration syntax.
public enum LearningModelFeatureKind : int
-->

# Windows.AI.MachineLearning.LearningModelFeatureKind

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Input and output feature kinds for a machine learning model.

## -enum-fields
### -field Tensor:0
The feature is a tensor, so use [TensorFeatureDescriptor](tensorfeaturedescriptor.md).

### -field Sequence:1
The feature is a sequence, so use [SequenceFeatureDescriptor](sequencefeaturedescriptor.md).

### -field Map:2
The feature is a map, so use [MapFeatureDescriptor](mapfeaturedescriptor.md).

### -field Image:3
The feature is an image, so use [ImageFeatureDescriptor](imagefeaturedescriptor.md).

## -remarks
Each of these maps to a corresponding feature descriptor that can be used to learn more about how to pass the feature into and out of the model.

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also
[Windows ML](/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples
