---
-api-id: M:Windows.AI.MachineLearning.LearningModelSession.EvaluateAsync(Windows.AI.MachineLearning.LearningModelBinding,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<LearningModelEvaluationResult> LearningModelSession.EvaluateAsync(LearningModelBinding bindings, String correlationId)
-->

# Windows.AI.MachineLearning.LearningModelSession.EvaluateAsync

## -description
Asynchronously evaluate the machine learning model using the feature values already bound in *bindings*.

## -parameters
### -param bindings
The values bound to the named input and output features.

### -param correlationId
Optional user-supplied string to connect the output results.

## -returns
A [LearningModelEvaluationResult](learningmodelevaluationresult.md) from the evaluation.

## -remarks

## -see-also

## -examples
The following example retrieves the first input and output features from the model, creates an output frame, binds the input and output features, and evaluates the model.

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
    LearningModelEvaluationResult _results;

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
        _results = await _session.EvaluateAsync(_binding, "test");
    }
    catch (Exception ex)
    {
        StatusBlock.Text = $"error: {ex.Message}";
        _model = null;
    }
}
```
