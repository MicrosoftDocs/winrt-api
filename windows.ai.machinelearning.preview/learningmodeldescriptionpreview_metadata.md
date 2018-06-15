---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Metadata
-api-type: winrt property
---

<!-- Property syntax.
public IMapView<string, string> Metadata { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Metadata

## -description
Gets the metadata from the model.

## -property-value
The metadata for the provided model. 

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
	
	Console.WriteLine($"Model Metadata: {model.Description.Metadata}.");
}
```
