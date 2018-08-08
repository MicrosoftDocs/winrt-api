---
-api-id: T:Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview
-api-type: winrt class
---

<!-- Class syntax.
public class ImageVariableDescriptorPreview : IImageVariableDescriptorPreview, ILearningModelVariableDescriptorPreview
-->

# Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview

## -description
**Deprecated.** Represents the image descriptor information.

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

	// Ensure the input feature handles the format RGBA8
    if (imageDescriptor.BitmapPixelFormat != BitmapPixelFormat.Rgba8)
    {
        Console.WriteLine($"Input Feature Name: {imageDescriptor.Name}. Format not supported.");
    }

 }
```

