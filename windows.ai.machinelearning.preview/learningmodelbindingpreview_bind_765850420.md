---
-api-id: M:Windows.AI.MachineLearning.Preview.LearningModelBindingPreview.Bind(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax.
public void LearningModelBindingPreview.Bind(String name, Object value)
-->

# Windows.AI.MachineLearning.Preview.LearningModelBindingPreview.Bind

## -description
Binds a single input or output feature to a defined variable.

## -parameters
### -param name
The name of the input/output feature.

### -param value
The value of the input/output feature.

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
```
