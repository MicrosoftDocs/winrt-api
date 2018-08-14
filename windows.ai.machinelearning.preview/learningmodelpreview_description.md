---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelPreview.Description
-api-type: winrt property
---

<!-- Property syntax.
public ILearningModelDescriptionPreview Description { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelPreview.Description

## -description
**Deprecated.** Gets the descriptive metadata for the trained machine learning model.

## -property-value
The descriptive metadata for the machine learning model.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public async Task LoadModel()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.onnx");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
 
    // Confirm the version of the model is 1
    if (model.Description.Version != 1)
    {
		...
    }
}
 ```
