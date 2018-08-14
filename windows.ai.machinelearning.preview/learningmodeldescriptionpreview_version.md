---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Version
-api-type: winrt property
---

<!-- Property syntax.
public long Version { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Version

## -description
**Deprecated.** Gets the version information of the model.

## -property-value
The version information of the model. 

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void Evaluator()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.onnx");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
	
	Console.WriteLine($"Model Version: {model.Description.Version}.");
}
```
