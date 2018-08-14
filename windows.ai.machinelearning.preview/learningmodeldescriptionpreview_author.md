---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Author
-api-type: winrt property
---

<!-- Property syntax.
public string Author { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Author

## -description
**Deprecated.** Gets the author information from the model.

## -property-value
The author information from the model.

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
	
	Console.WriteLine($"Model Author: {model.Description.Author}.");
}
```
