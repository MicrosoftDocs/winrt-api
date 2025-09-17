---
-api-id: P:Windows.AI.MachineLearning.LearningModel.InputFeatures
-api-type: winrt property
ms.custom: RS5
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Property syntax.
public IVectorView<ILearningModelFeatureDescriptor> InputFeatures { get; }
-->

# Windows.AI.MachineLearning.LearningModel.InputFeatures

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

A list of the model's input features.

## -property-value
A list of the model's input features.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

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
