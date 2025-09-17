---
-api-id: M:Windows.AI.MachineLearning.LearningModelSession.#ctor(Windows.AI.MachineLearning.LearningModel,Windows.AI.MachineLearning.LearningModelDevice)
-api-type: winrt method
ms.custom: RS5
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Method syntax.
public LearningModelSession.LearningModelSession(LearningModel model, LearningModelDevice deviceToRunOn)
-->

# Windows.AI.MachineLearning.LearningModelSession.LearningModelSession

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Creates a session using the specified device.

## -parameters
### -param model
The trained machine learning model for this session.

### -param deviceToRunOn
The session's evaluation device.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
The following example loads a model, selects the device on which to evaluate the model, and creates an evaluation session.

```csharp
private async Task LoadModelAsync(string _modelFileName, bool _useGPU, LearningModelSession _session)
{
    LearningModel _model;

    try
    {
        // Load and create the model
        var modelFile = 
            await StorageFile.GetFileFromApplicationUriAsync(new Uri($"ms-appx:///Assets/{_modelFileName}"));
        _model = await LearningModel.LoadFromStorageFileAsync(modelFile);

        // Select the device to evaluate on
        LearningModelDevice device = null;
        if (_useGPU)
        {
            // Use a GPU or other DirectX device to evaluate the model.
            device = new LearningModelDevice(LearningModelDeviceKind.DirectX);
        }
        else
        {
            // Use the CPU to evaluate the model.
            device = new LearningModelDevice(LearningModelDeviceKind.Cpu);
        }

        // Create the evaluation session with the model and device.
        _session = new LearningModelSession(_model, device);

    }
    catch (Exception ex)
    {
        StatusBlock.Text = $"error: {ex.Message}";
        _model = null;
    }
}
```
