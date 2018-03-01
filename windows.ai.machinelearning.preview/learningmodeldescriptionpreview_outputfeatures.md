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
 ```csharp
public void Evaluator()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.onnx");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);

	// Retrieve the model output variable description (as a tensor)
    ILearningModelVariableDescriptorPreview outputTensorDescription = outputFeatures.FirstOrDefault(feature => feature.ModelFeatureKind == LearningModelFeatureKindPreview.Tensor) as TensorVariableDescriptorPreview;

 }
```