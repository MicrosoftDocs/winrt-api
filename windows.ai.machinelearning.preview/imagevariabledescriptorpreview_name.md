---
-api-id: P:Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.ImageVariableDescriptorPreview.Name

## -description
Gets the name of the image variable.

## -property-value
The name of the image variable.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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