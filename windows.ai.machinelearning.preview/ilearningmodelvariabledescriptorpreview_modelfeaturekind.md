---
-api-id: P:Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.ModelFeatureKind
-api-type: winrt property
---

<!-- Property syntax.
public LearningModelFeatureKindPreview ModelFeatureKind { get; }
-->

# Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.ModelFeatureKind

## -description
Gets the data type of the variable.

## -property-value
The data type of the variable.

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

	// Ensure the input feature is of type image
    if (imageDescriptor.ModelFeatureKind != LearningModelFeatureKindPreview.Image)
    {
        Console.WriteLine($"Input Feature Name: {imageDescriptor.Name}. Feature type is not an image.");
    }

 }
```