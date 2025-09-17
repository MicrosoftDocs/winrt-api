---
-api-id: P:Windows.AI.MachineLearning.LearningModel.Description
-api-type: winrt property
ms.custom: RS5
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Property syntax.
public string Description { get; }
-->

# Windows.AI.MachineLearning.LearningModel.Description

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

A description of the model.

## -property-value
A description of the model.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
The following example loads a model from a local file, outputs the model description to the application's UI, and creates a session from the model.

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

        //Output the model description to application UI
        StatusBlock.Text = $"Model Description: {_model.Description}";

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
