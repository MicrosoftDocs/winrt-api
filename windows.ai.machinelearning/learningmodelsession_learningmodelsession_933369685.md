---
-api-id: M:Windows.AI.MachineLearning.LearningModelSession.#ctor(Windows.AI.MachineLearning.LearningModel)
-api-type: winrt method
ms.custom: RS5
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Method syntax.
public LearningModelSession.LearningModelSession(LearningModel model)
-->

# Windows.AI.MachineLearning.LearningModelSession.LearningModelSession

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Creates a session using the default device.

## -parameters
### -param model
The trained machine learning model for this session.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
The following example loads a model and creates an evaluation session with it.

```csharp
private async Task LoadModelAsync(LearningModel _model, string _modelFileName, LearningModelSession _session)
{
    // Only load the model one time.
    if (_model != null) return;

    try
    {
        // Load and create the model
        var modelFile = 
            await StorageFile.GetFileFromApplicationUriAsync(new Uri($"ms-appx:///Assets/{_modelFileName}"));
        _model = await LearningModel.LoadFromStorageFileAsync(modelFile);

        // Create the evaluation session with the model and device.
        _session = new LearningModelSession(_model);
    }
    catch (Exception ex)
    {
        StatusBlock.Text = $"error: {ex.Message}";
        _model = null;
    }
}
```
