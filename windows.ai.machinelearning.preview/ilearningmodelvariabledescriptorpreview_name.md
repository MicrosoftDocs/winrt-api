---
-api-id: P:Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.Name

## -description
Gets the name of the variable.

## -property-value
The name of the variable.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

Name must be unique across all other variables in the model.

## -see-also

## -examples
```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is an image
    ILearningModelVariableDescriptorPreview inputImageFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    ImageVariableDescriptorPreview imageDescriptor = (ImageVariableDescriptorPreview)inputImageFeatureDescription;

	// Ensure the input feature has the specified name "data"
    if (imageDescriptor.Name == "data")
    {
        Console.WriteLine($"Verified. Input variable name is: {imageDescriptor.Name}");
    }
 }
```