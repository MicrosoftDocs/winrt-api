---
-api-id: P:Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview.ModelFeatureKind
-api-type: winrt property
---

<!-- Property syntax.
public LearningModelFeatureKindPreview ModelFeatureKind { get; }
-->

# Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview.ModelFeatureKind

## -description
**Deprecated.** Gets the data type of the variable.

## -property-value
The data type of the variable.

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

	// Ensure the input feature is of type image
    if (imageDescriptor.ModelFeatureKind != LearningModelFeatureKindPreview.Image)
    {
        Console.WriteLine($"Input Feature Name: {imageDescriptor.Name}. Feature type is not an image.");
    }

 }
 ```