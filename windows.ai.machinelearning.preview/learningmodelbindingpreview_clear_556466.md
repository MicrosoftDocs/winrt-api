---
-api-id: M:Windows.AI.MachineLearning.Preview.LearningModelBindingPreview.Clear
-api-type: winrt method
---

<!-- Method syntax.
public void LearningModelBindingPreview.Clear()
-->

# Windows.AI.MachineLearning.Preview.LearningModelBindingPreview.Clear

## -description
Clears all bound variables. 

## -remarks

## -see-also

## -examples
public void PrepareBinding(LearningModelPreview model, SoftwareBitmap picture)
{
	List<ILearningModelVariableDescriptorPreview> inputFeatures = _model.Description.InputFeatures.ToList();

    ImageVariableDescriptorPreview _inputImageDescription =
                    inputFeatures.FirstOrDefault(feature => feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image)
                    as ImageVariableDescriptorPreview;

    // Bind the image
    LearningModelBindingPreview binding = new LearningModelBindingPreview(model);
    binding.Bind(_inputImageDescription.Name, picture);
	
	
	...
	
	
	binding.Clear();
}
