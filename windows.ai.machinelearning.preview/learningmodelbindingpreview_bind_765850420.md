---
-api-id: M:Windows.AI.MachineLearning.Preview.LearningModelBindingPreview.Bind(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax.
public void LearningModelBindingPreview.Bind(String name, Object value)
-->

# Windows.AI.MachineLearning.Preview.LearningModelBindingPreview.Bind

## -description
**Deprecated.** Binds a single input or output feature to a defined variable.

## -parameters
### -param name
The name of the input/output feature.

### -param value
The value of the input/output feature.

## -remarks
**Note**: Currently, outputs of type `double` are not supported. If possible, consider using type `float` instead.

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
```
