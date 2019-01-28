---
-api-id: T:Windows.AI.MachineLearning.LearningModelSession
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LearningModelSession : IClosable
-->

# Windows.AI.MachineLearning.LearningModelSession

## -description
Used to evaluate machine learning models.

## -remarks

## -see-also
[Windows ML](https://docs.microsoft.com/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples
The following example loads a model and creates an evaluation session with it.

```csharp
private async Task LoadModelAsync(string _modelFileName)
{
    LearningModel _model;
    LearningModelSession _session;

    try
    {
        // Load and create the model
        var modelFile = 
            await StorageFile.GetFileFromApplicationUriAsync(new Uri($"ms-appx:///Assets/{_modelFileName}"));
        _model = await LearningModel.LoadFromStorageFileAsync(modelFile);

        // Create the evaluation session with the model
        _session = new LearningModelSession(_model);

    }
    catch (Exception ex)
    {
        StatusBlock.Text = $"error: {ex.Message}";
        _model = null;
    }
}
```
