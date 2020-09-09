---
-api-id: N:Windows.AI.MachineLearning
-api-type: winrt namespace
ms.custom: RS5
---

<!-- Namespace syntax.
namespace Windows.AI.MachineLearning
-->

# Windows.AI.MachineLearning

## -description

Enables apps to load machine learning models, bind features, and evaluate the results.

## -remarks

### Windows Server

To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety

This API is thread-safe.

## -see-also

[Windows ML](/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples

The following example loads a model, creates an evaluation session, gets the input and output features of the model, binds those features, and evaluates.

```csharp
private async Task LoadAndEvaluateModelAsync(VideoFrame _inputFrame, string _modelFileName)
{
    LearningModel _model;
    ImageFeatureDescriptor _inputImageDescription;
    TensorFeatureDescriptor _outputImageDescription;
    LearningModelBinding _binding = null;
    VideoFrame _outputFrame = null;
    LearningModelSession _session;

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
        _inputImageDescription =
                inputFeatures.FirstOrDefault(feature => feature.Kind == LearningModelFeatureKind.Image)
                as ImageFeatureDescriptor;

        // Retrieve the first output feature which is a tensor
        _outputImageDescription =
                        outputFeatures.FirstOrDefault(feature => feature.Kind == LearningModelFeatureKind.Tensor)
                        as TensorFeatureDescriptor;

        //Create output frame based on expected image width and height
        _outputFrame = new VideoFrame(
            BitmapPixelFormat.Bgra8, 
            (int)_inputImageDescription.Width, 
            (int)_inputImageDescription.Height);

        //Create binding and then bind input/output features
        _binding = new LearningModelBinding(_session);

        _binding.Bind(_inputImageDescription.Name, _inputFrame);
        _binding.Bind(_outputImageDescription.Name, _outputFrame);

        //Evaluate and get the results
        var results = await _session.EvaluateAsync(_binding, "test");
    }
    catch (Exception ex)
    {
        StatusBlock.Text = $"error: {ex.Message}";
        _model = null;
    }
}
```
