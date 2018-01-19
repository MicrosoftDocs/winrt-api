---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.OutputFeatures
-api-type: winrt property
---

<!-- Property syntax.
public IIterable<ILearningModelVariableDescriptorPreview> OutputFeatures { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.OutputFeatures

## -description
Gets the output descriptions of the model.

## -property-value
The output descriptions for the model, keyed by the name of the output. 

## -remarks

## -see-also

## -examples

public void Evaluator(LearningModelPreview model)
{
	// Retrieve the model output variable description (as a tensor)
    ILearningModelVariableDescriptorPreview outputTensorFeatureDescription = model.Description.OutputFeatures.FirstOrDefault(feature => feature.ModelFeatureKind == LearningModelFeatureKindPreview.Tensor)
                    as TensorVariableDescriptorPreview;
 
	...

 }
