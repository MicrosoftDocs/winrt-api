---
-api-id: P:Windows.AI.MachineLearning.Preview.TensorVariableDescriptorPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.TensorVariableDescriptorPreview.Name

## -description
**Deprecated.** Gets the name of the tensor.

## -property-value
The name of the tensor. This must be unique across all variables in the model.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is a Tensor
    ILearningModelVariableDescriptorPreview inputTensorFeatureDescription = model.Description.InputFeatures.First(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Tensor);
 
    TensorVariableDescriptorPreview TensorDescriptor = (TensorVariableDescriptorPreview)inputTensorFeatureDescription;

	// Output the description of the Tensor variable
    Console.WriteLine($"Input Feature Name: {TensorDescriptor.Name}. Description: {TensorDescriptor.Description}.");
 }
 ```