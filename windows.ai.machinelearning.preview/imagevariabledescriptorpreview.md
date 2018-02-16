---
-api-id: T:Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview
-api-type: winrt class
---

<!-- Class syntax.
public class ImageVariableDescriptorPreview : IImageVariableDescriptorPreview, ILearningModelVariableDescriptorPreview
-->

# Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview

## -description
Represents the image descriptor information.

## -remarks

## -see-also

## -examples
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is an image
    ILearningModelVariableDescriptorPreview inputImageFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    ImageVariableDescriptorPreview imageDescriptor = (ImageVariableDescriptorPreview)inputImageFeatureDescription;

	// Ensure the input feature handles the format RGBA8
    if (imageDescriptor.BitmapPixelFormat != BitmapPixelFormat.Rgba8)
    {
        Console.WriteLine($"Input Feature Name: {imageDescriptor.Name}. Format not supported.);
    }

 }


