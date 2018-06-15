---
-api-id: P:Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview.BitmapPixelFormat
-api-type: winrt property
---

<!-- Property syntax.
public BitmapPixelFormat BitmapPixelFormat { get; }
-->

# Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview.BitmapPixelFormat

## -description
Gets the pixel format of the image.

## -property-value
Pixel format of the image.

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

	// Ensure the input feature handles the format RGBA8
    if (imageDescriptor.BitmapPixelFormat != BitmapPixelFormat.Rgba8)
    {
        Console.WriteLine($"Input Feature Name: {imageDescriptor.Name}. Format not supported.");
    }

 }
 ```

