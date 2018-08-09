---
-api-id: T:Windows.AI.MachineLearning.Preview.LearningModelFeatureKindPreview
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum LearningModelFeatureKindPreview : int 
-->

# Windows.AI.MachineLearning.Preview.LearningModelFeatureKindPreview

## -description
**Deprecated.** Defines the list of data types for a model feature

## -enum-fields
### -field Undefined:0
The feature type is Undefined.

### -field Tensor:1
The feature type is a Tensor.

### -field Sequence:2
The feature type is a Sequence.

### -field Map:3
The feature type is a Map.

### -field Image:4
The feature type is an Image. 

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is an image
    ILearningModelVariableDescriptorPreview inputImageFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    ImageVariableDescriptorPreview imageDescriptor = (ImageVariableDescriptorPreview)inputImageFeatureDescription;

	...

 }
```