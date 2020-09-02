---
-api-id: T:Windows.AI.MachineLearning.LearningModel
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LearningModel : IClosable
-->

# Windows.AI.MachineLearning.LearningModel

## -description
Represents a trained machine learning model.

## -remarks
This is the main object you use to interact with Windows ML. You use it to load, bind, and evaluate trained ONNX models:

1. Load the model using one of the **Load**\* constructors.  
2. Enumerate the [InputFeatures](learningmodel_inputfeatures.md) and [OutputFeatures](learningmodel_outputfeatures.md) and bind to your model.
3. Create a [LearningModelSession](learningmodelsession.md) and evalaute.

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also
[Windows ML](/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

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
