---
-api-id: P:Windows.AI.MachineLearning.Preview.TensorVariableDescriptorPreview.ModelFeatureKind
-api-type: winrt property
---

<!-- Property syntax.
public LearningModelFeatureKindPreview ModelFeatureKind { get; }
-->

# Windows.AI.MachineLearning.Preview.TensorVariableDescriptorPreview.ModelFeatureKind

## -description
Gets the data type of the variable.

## -property-value
The data type of the variable.

## -remarks

## -see-also

## -examples
 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is a Tensor
    ILearningModelVariableDescriptorPreview inputTensorFeatureDescription = model.Description.InputFeatures.First(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Tensor);
 
    TensorVariableDescriptorPreview TensorDescriptor = (TensorVariableDescriptorPreview)inputTensorFeatureDescription;

	// Ensure the input feature is of type Tensor
    if (TensorDescriptor.ModelFeatureKind != LearningModelFeatureKindPreview.Tensor)
    {
        Console.WriteLine($"Input Feature Name: {TensorDescriptor.Name}. Feature type is not a Tensor.");
    }

 }

 ```
