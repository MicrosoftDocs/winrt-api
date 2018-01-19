---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.InputFeatures
-api-type: winrt property
---

<!-- Property syntax.
public IIterable<ILearningModelVariableDescriptorPreview> InputFeatures { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.InputFeatures

## -description
Gets the input descriptions for the model.

## -property-value
The input descriptions for the model, keyed by name of input. 

## -remarks

## -see-also

## -examples
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is an image
    ILearningModelVariableDescriptorPreview inputImageFeatureDescription = model.Description.InputFeatures.First(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
	...

 }


