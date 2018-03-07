---
-api-id: P:Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.Description
-api-type: winrt property
---

<!-- Property syntax.
public string Description { get; }
-->

# Windows.AI.MachineLearning.Preview.ILearningModelVariableDescriptorPreview.Description

## -description
Gets the description of the variable.

## -property-value
The description of the variable.

## -remarks

## -see-also

## -examples
```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is an image
    ILearningModelVariableDescriptorPreview inputImageFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    ImageVariableDescriptorPreview imageDescriptor = (ImageVariableDescriptorPreview)inputImageFeatureDescription;

	//Output input feature description
    Console.WriteLine($"Input Feature Name: {imageDescriptor.Name}. Feature Descption: {imageDescriptor.Description}");
 }
```