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
Name must be unique across all other variables in the model.

## -see-also

## -examples
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is an image
    ILearningModelVariableDescriptorPreview inputImageFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    ImageVariableDescriptorPreview imageDescriptor = (ImageVariableDescriptorPreview)inputImageFeatureDescription;

	// Ensure the input feature has the correct name
    if (imageDescriptor.Name != "data")
    {
        throw new Exception("Invalid feature name");
    }

 }
