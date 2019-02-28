---
-api-id: M:Windows.AI.MachineLearning.LearningModel.LoadFromStorageFileAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<LearningModel> LearningModel.LoadFromStorageFileAsync(IStorageFile modelFile)
-->

# Windows.AI.MachineLearning.LearningModel.LoadFromStorageFileAsync

## -description
Loads an ONNX model from an [IStorageFile](../windows.storage/istoragefile.md) asynchronously.

## -parameters
### -param modelFile
The location of the model file.

## -returns
A [LearningModel](learningmodel.md) based on the model file.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
The following example loads the model and creates an evaulation session with it.

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
