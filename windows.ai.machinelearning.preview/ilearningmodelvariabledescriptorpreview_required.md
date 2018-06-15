---
-api-id: P:Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.IsRequired
-api-type: winrt property
---

<!-- Property syntax.
public bool IsRequired { get; }
-->

# Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.IsRequired

## -description
Gets whether the variable is required or optional.

## -property-value
True if the variable is required; otherwise false. 

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

	//Verify if the input feature is required or optional.
    if (imageDescriptor.IsRequired == true)
    {
        Console.WriteLine($"Input Feature Name: {imageDescriptor.Name} is required.");
    }
 }
 ```

