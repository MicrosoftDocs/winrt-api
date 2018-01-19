---
-api-id: T:Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview
-api-type: winrt class
---

<!-- Class syntax.
public class ImageVariableDescriptorPreview : IImageVariableDescriptorPreview, ILearningModelVariableDescriptorPreview
-->

# Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview

## -description
Gets the description of the image.

## -remarks

## -see-also

## -examples
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is an image
    ILearningModelVariableDescriptorPreview inputImageFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    ImageVariableDescriptorPreview imageDescriptor = (ImageVariableDescriptorPreview)inputImageFeatureDescription;

	// Ensure the input feature is of the format RGBA8
    if (imageDescriptor.BitmapPixelFormat != BitmapPixelFormat.Rgba8)
    {
        throw new Exception("Invalid image format");
    }

 }


