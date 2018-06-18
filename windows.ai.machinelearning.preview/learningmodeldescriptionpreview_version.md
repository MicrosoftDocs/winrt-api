---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Version
-api-type: winrt property
---

<!-- Property syntax.
public long Version { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Version

## -description
Gets the version information of the model.

## -property-value
The version information of the model. 

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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
