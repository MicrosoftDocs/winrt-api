---
-api-id: T:Windows.AI.MachineLearning.Preview.LearningModelFeatureKindPreview
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum LearningModelFeatureKindPreview : int 
-->

# Windows.AI.MachineLearning.Preview.LearningModelFeatureKindPreview

## -description
Defines the list of data types for a model feature

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

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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