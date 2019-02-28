---
-api-id: M:Windows.AI.MachineLearning.LearningModelDevice.#ctor(Windows.AI.MachineLearning.LearningModelDeviceKind)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public LearningModelDevice.LearningModelDevice(LearningModelDeviceKind deviceKind)
-->

# Windows.AI.MachineLearning.LearningModelDevice.LearningModelDevice

## -description
Create a [LearningModelDevice](learningmodeldevice.md) from the specified [LearningModelDeviceKind](learningmodeldevicekind.md).

## -parameters
### -param deviceKind
The specified **LearningModelDeviceKind** to evaluate the model on.

## -remarks

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
The following example loads a model, selects the device on which to evaluate the model, and evaluates.

```csharp
private async Task LoadModelAsync(string _modelFileName, bool _useGPU)
{
    LearningModel _model;
    LearningModelSession _session;

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
