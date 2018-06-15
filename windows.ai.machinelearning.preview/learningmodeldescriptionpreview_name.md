---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Name

## -description
Gets the name of the model.

## -property-value
The name of the model.

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
	
	Console.WriteLine($"Model Name: {model.Description.Name}.");
}
```