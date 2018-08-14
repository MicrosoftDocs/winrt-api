---
-api-id: T:Windows.AI.MachineLearning.Preview.LearningModelPreview
-api-type: winrt class
---

<!-- Class syntax.
public class LearningModelPreview : ILearningModelPreview
-->

# Windows.AI.MachineLearning.Preview.LearningModelPreview

## -description
**Deprecated.** Represents a machine learning model.

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
	
	...
}
```
