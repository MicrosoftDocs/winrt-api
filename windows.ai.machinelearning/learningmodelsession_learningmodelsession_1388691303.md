---
-api-id: M:Windows.AI.MachineLearning.LearningModelSession.#ctor(Windows.AI.MachineLearning.LearningModel,Windows.AI.MachineLearning.LearningModelDevice,Windows.AI.MachineLearning.LearningModelSessionOptions)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public LearningModelSession.LearningModelSession(LearningModel model, LearningModelDevice deviceToRunOn, LearningModelSessionOptions learningModelSessionOptions)
-->

# Windows.AI.MachineLearning.LearningModelSession.LearningModelSession

## -description
Creates a session using the specified device and additional inference options.

## -parameters
### -param model
The trained machine learning model for this session.

### -param deviceToRunOn
The session's evaluation device.

### -param learningModelSessionOptions
The options used to configure session creation and evaluation.

## -remarks

## -see-also

## -examples
The following example loads a model and configures an evaluation session using [LearningModelSessionOptions](learningmodelsessionoptions.md).

```csharp
private LearningModelSessionOptions CreateSessionOptions()
{
    var options = new LearningModelSessionOptions();

    // Disable constant batch size optimizations
    options.BatchSizeOverride = 0;

    return options;
}

private async Task LoadModelAsync(string modelFileName)
{
    LearningModel model;
    LearningModelDevice device;
    LearningModelSession session;

    try
    {
        // Load and create the model.
        var modelFile = 
            await StorageFile.GetFileFromApplicationUriAsync(new Uri($"ms-appx:///Assets/{modelFileName}"));
        model = await LearningModel.LoadFromStorageFileAsync(modelFile);

        // Create default LearningModelDevice.
        device = new LearningModelDevice(LearningModelDeviceKind.Default);

        // Create LearningModelSessionOptions with necessary options set.
        LearningModelSessionOptions options = CreateSessionOptions();

        // Create the evaluation session with the model and LearningModelSessionOptions.
        session = new LearningModelSession(model, device, options);

    }
    catch (Exception ex)
    {
        StatusBlock.Text = $"error: {ex.Message}";
        model = null;
    }
}
```


