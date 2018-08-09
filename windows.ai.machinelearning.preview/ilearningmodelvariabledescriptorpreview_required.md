---
-api-id: P:Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.IsRequired
-api-type: winrt property
---

<!-- Property syntax.
public bool IsRequired { get; }
-->

# Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.IsRequired

## -description
**Deprecated.** Gets whether the variable is required or optional.

## -property-value
True if the variable is required; otherwise false. 

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

	//Verify if the input feature is required or optional.
    if (imageDescriptor.IsRequired == true)
    {
        Console.WriteLine($"Input Feature Name: {imageDescriptor.Name} is required.");
    }
 }
 ```

