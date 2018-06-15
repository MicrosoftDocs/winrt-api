---
-api-id: P:Windows.AI.MachineLearning.Preview.TensorVariableDescriptorPreview.Description
-api-type: winrt property
---

<!-- Property syntax.
public string Description { get; }
-->

# Windows.AI.MachineLearning.Preview.TensorVariableDescriptorPreview.Description

## -description
Gets the description of the tensor.

## -property-value
The description of the tensor.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

## -see-also

## -examples
 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is a Tensor
    ILearningModelVariableDescriptorPreview inputTensorFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    TensorVariableDescriptorPreview TensorDescriptor = (TensorVariableDescriptorPreview)inputTensorFeatureDescription;

	// Output the description of the Tensor variable
    Console.WriteLine($"Input Feature Name: {TensorDescriptor.Name}. Description: {TensorDescriptor.Description}.");

 }

 ```
