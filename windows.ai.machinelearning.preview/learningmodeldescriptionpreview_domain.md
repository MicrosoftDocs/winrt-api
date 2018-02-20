---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Domain
-api-type: winrt property
---

<!-- Property syntax.
public string Domain { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Domain

## -description
Gets the domain information for the model.

## -property-value
The domain information for the model.

## -remarks

## -see-also

## -examples
 ```csharp
public void Evaluator()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.onnx");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
	
	Console.WriteLine($"Model Domain: {model.Description.Domain}.");
}
```