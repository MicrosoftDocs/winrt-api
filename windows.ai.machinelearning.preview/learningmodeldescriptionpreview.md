---
-api-id: T:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview
-api-type: winrt class
---

<!-- Class syntax.
public class LearningModelDescriptionPreview : ILearningModelDescriptionPreview
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview

## -description
Represents the metadata and property descriptions for the provided model.

## -remarks

## -see-also

## -examples
 ```csharp
public void Evaluator()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
 
    // Our evaluator only handles version 1 of the model
    if (model.Description.Version != 1)
    {
        throw new Exception("Invalid model version");
    }
}
```

