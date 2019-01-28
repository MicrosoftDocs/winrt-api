---
-api-id: M:Windows.AI.MachineLearning.LearningModelSession.#ctor(Windows.AI.MachineLearning.LearningModel,Windows.AI.MachineLearning.LearningModelDevice)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public LearningModelSession.LearningModelSession(LearningModel model, LearningModelDevice deviceToRunOn)
-->

# Windows.AI.MachineLearning.LearningModelSession.LearningModelSession

## -description
Creates a session using the specified device.

## -parameters
### -param model
The trained machine learning model for this session.

### -param deviceToRunOn
The session's evaluation device.

## -remarks

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
