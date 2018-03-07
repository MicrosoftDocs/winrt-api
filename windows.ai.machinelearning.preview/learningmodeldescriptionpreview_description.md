---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Description
-api-type: winrt property
---

<!-- Property syntax.
public string Description { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Description

## -description
Gets the custom description of the model.

## -property-value
The custom description of the model.

## -remarks

## -see-also

## -examples
 ```csharp
public void Evaluator()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.onnx");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
	
	Console.WriteLine($"Model Description: {model.Description.Description}.");
}
```