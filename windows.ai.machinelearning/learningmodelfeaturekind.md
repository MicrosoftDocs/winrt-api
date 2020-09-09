---
-api-id: T:Windows.AI.MachineLearning.LearningModelFeatureKind
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum LearningModelFeatureKind : int
-->

# Windows.AI.MachineLearning.LearningModelFeatureKind

## -description
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
