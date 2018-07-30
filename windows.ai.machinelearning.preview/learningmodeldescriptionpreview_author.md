---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Author
-api-type: winrt property
---

<!-- Property syntax.
public string Author { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Author

## -description
Gets the author information from the model.

## -property-value
The author information from the model.

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
	
	Console.WriteLine($"Model Author: {model.Description.Author}.");
}
```
