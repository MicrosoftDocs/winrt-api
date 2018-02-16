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

## -see-also

## -examples
public void Evaluator()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.onnx");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
	
	Console.WriteLine($"Model Name: {model.Description.Name}.);
}
