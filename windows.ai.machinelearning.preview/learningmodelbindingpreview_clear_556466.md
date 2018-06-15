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

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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
