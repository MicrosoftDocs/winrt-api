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

## -see-also

## -examples
void Evaluator()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.pb");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
 
    // Confirm the version of the model is 1
    if (model.Description.Version != 1)
    {
        throw new Exception("Invalid model version");
    }
}

