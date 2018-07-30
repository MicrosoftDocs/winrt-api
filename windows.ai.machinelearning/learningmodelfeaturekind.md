---
-api-id: T:Windows.AI.MachineLearning.LearningModelFeatureKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum LearningModelFeatureKind : int
-->

# Windows.AI.MachineLearning.LearningModelFeatureKind

## -description
Input and output feature kinds for a machine learning model.

## -enum-fields
### -field Tensor:0
The feature is a tensor, use TensorFeatureDescriptor.
### -field Sequence:1
The feature is a sequence, use SequenceFeatureDescriptor.
### -field Map:2
The feature is a map, use MapFeatureDescriptor.
### -field Image:3
The feature is an image, use ImageFeatureDescriptor.
## -remarks
Each of these maps to a corresponding FeatureDescriptor that can be used to learn more about how to pass the feature into and out of the model.
## -see-also

## -examples
