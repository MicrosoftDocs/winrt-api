---
-api-id: T:Windows.AI.MachineLearning.ImageFeatureDescriptor
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class ImageFeatureDescriptor : ILearningModelFeatureDescriptor
-->

# Windows.AI.MachineLearning.ImageFeatureDescriptor

## -description
Describes the properties of the image the model is expecting.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also
[Windows ML](/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples
The following example loads a model from a local file, creates a session from it, and gets the input and output features.

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

        //Get input and output features of the model
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
