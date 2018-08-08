---
-api-id: M:Windows.AI.MachineLearning.Preview.LearningModelBindingPreview.Clear
-api-type: winrt method
---

<!-- Method syntax.
public void LearningModelBindingPreview.Clear()
-->

# Windows.AI.MachineLearning.Preview.LearningModelBindingPreview.Clear

## -description
**Deprecated.** Clears all bound variables. 

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void PrepareBinding(LearningModelPreview model, VideoFrame picture)
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
```
