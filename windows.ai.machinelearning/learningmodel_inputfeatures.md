---
-api-id: P:Windows.AI.MachineLearning.LearningModel.InputFeatures
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IVectorView<ILearningModelFeatureDescriptor> InputFeatures { get; }
-->

# Windows.AI.MachineLearning.LearningModel.InputFeatures

## -description
A list of the model's input features.

## -property-value
A list of the model's input features.

## -remarks

## -see-also

## -examples
The following example loads a model from a local file, creates a session from the model, and gets the input and output features of the model.

```csharp
private async Task LoadModelAsync(string _modelFileName)
{
    LearningModel _model;
    LearningModelSession _session;
    ImageFeatureDescriptor _inputImageDescription;
    TensorFeatureDescriptor _outputImageDescription;

    try
    {
        // Load and create the model
        var modelFile = 
            await StorageFile.GetFileFromApplicationUriAsync(new Uri($"ms-appx:///Assets/{_modelFileName}"));
        _model = await LearningModel.LoadFromStorageFileAsync(modelFile);

        // Create the evaluation session with the model
        _session = new LearningModelSession(_model);

        // Get input and output features of the model
        List<ILearningModelFeatureDescriptor> inputFeatures = _model.InputFeatures.ToList();
        List<ILearningModelFeatureDescriptor> outputFeatures = _model.OutputFeatures.ToList();

        // Retrieve the first input feature which is an image
        _inputImageDescription = inputFeatures.FirstOrDefault(
            feature => feature.Kind == LearningModelFeatureKind.Image) as ImageFeatureDescriptor;

        // Retrieve the first output feature which is a tensor
        _outputImageDescription = outputFeatures.FirstOrDefault(
            feature => feature.Kind == LearningModelFeatureKind.Tensor) as TensorFeatureDescriptor;
    }
    catch (Exception ex)
    {
        StatusBlock.Text = $"error: {ex.Message}";
        _model = null;
    }
}
```
