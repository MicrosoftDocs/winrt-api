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
	ImageVariableDescriptorPreview inputImageDescription;
	List<ILearningModelVariableDescriptorPreview> inputFeatures = model.Description.InputFeatures.ToList();

    inputImageDescription =
         inputFeatures.FirstOrDefault(feature => feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image)
         as ImageVariableDescriptorPreview;

    // Bind the image
    var binding = new LearningModelBindingPreview(model);
    binding.Bind(inputImageDescription, picture);
}
	
	//Evaluate and other application logic
	...
	
	
	binding.Clear();
}
