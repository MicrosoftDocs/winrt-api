---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Metadata
-api-type: winrt property
---

<!-- Property syntax.
public IMapView<string, string> Metadata { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Metadata

## -description
**Deprecated.** Gets the metadata from the model.

## -property-value
The metadata for the provided model. 

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
	
	Console.WriteLine($"Model Metadata: {model.Description.Metadata}.");
}
```
