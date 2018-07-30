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

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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