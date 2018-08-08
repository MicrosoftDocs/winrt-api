---
-api-id: P:Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview.Name

## -description
**Deprecated.** Gets the name of the image variable.

## -property-value
The name of the image variable.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

This must be unique across all variables in the model.

## -see-also

## -examples
 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is an image
    ILearningModelVariableDescriptorPreview inputImageFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    ImageVariableDescriptorPreview imageDescriptor = (ImageVariableDescriptorPreview)inputImageFeatureDescription;

	// Output the description of the image variable
    Console.WriteLine($"Input Feature Name: {imageDescriptor.Name}. Description: {imageDescriptor.Description}.");

 }
```