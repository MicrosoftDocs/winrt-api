---
-api-id: M:Windows.AI.MachineLearning.LearningModelBinding.Bind(System.String,System.Object)
-api-type: winrt method
---

<!-- Method syntax.
public void LearningModelBinding.Bind(String name, Object value)
-->

# Windows.AI.MachineLearning.LearningModelBinding.Bind

## -description
Bind a value to the named feature.

## -parameters
### -param name
The name of the feature.

### -param value
The value to bind.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
The following example retrieves the first input and output features, creates an output frame, binds the input and output features, and evaulates.

```csharp
private async Task EvaluateModelAsync(
    VideoFrame _inputFrame, 
    LearningModelSession _session, 
    IReadOnlyList<ILearningModelFeatureDescriptor> _inputFeatures, 
    IReadOnlyList<ILearningModelFeatureDescriptor> _outputFeatures,
    LearningModel _model)
{
    ImageFeatureDescriptor _inputImageDescription;
    TensorFeatureDescriptor _outputImageDescription;
    LearningModelBinding _binding = null;
    VideoFrame _outputFrame = null;

    try
    {
        // Retrieve the first input feature which is an image
        _inputImageDescription =
            _inputFeatures.FirstOrDefault(feature => feature.Kind == LearningModelFeatureKind.Image)
            as ImageFeatureDescriptor;

        // Retrieve the first output feature which is a tensor
        _outputImageDescription =
            _outputFeatures.FirstOrDefault(feature => feature.Kind == LearningModelFeatureKind.Tensor)
            as TensorFeatureDescriptor;

        // Create output frame based on expected image width and height
        _outputFrame = new VideoFrame(
            BitmapPixelFormat.Bgra8, 
            (int)_inputImageDescription.Width, 
            (int)_inputImageDescription.Height);

        // Create binding and then bind input/output features
        _binding = new LearningModelBinding(_session);

        _binding.Bind(_inputImageDescription.Name, _inputFrame);
        _binding.Bind(_outputImageDescription.Name, _outputFrame);

        // Evaluate and get the results
        var results = await _session.EvaluateAsync(_binding, "test");
    }
    catch (Exception ex)
    {
        StatusBlock.Text = $"error: {ex.Message}";
        _model = null;
    }
}
```
