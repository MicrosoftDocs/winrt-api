---
-api-id: T:Windows.AI.MachineLearning.LearningModelDeviceKind
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum LearningModelDeviceKind : int
-->

# Windows.AI.MachineLearning.LearningModelDeviceKind

## -description
Defines the list of device kinds that can evaluate a machine learning model.

## -enum-fields
### -field Default:0
Let the system decide which device to use.

### -field Cpu:1
Use the CPU to evaluate the model.

### -field DirectX:2
Use a GPU or other DirectX device to evaluate the model.

### -field DirectXHighPerformance:3
Use the system policy-defined device for high performance.

### -field DirectXMinPower:4
Use the system policy-defined device for minimum power.

## -remarks
If not specified, the system will decide which device to use.

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also
[Windows ML](/windows/ai/), [Windows ML samples (GitHub)](https://github.com/Microsoft/Windows-Machine-Learning/tree/master)

## -examples
The following example loads a model, selects the device on which to evaluate the model, and creates an evaluation session.

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
