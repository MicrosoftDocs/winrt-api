---
-api-id: T:Windows.AI.MachineLearning.Preview.LearningModelPreview
-api-type: winrt class
---

<!-- Class syntax.
public class LearningModelPreview : ILearningModelPreview
-->

# Windows.AI.MachineLearning.Preview.LearningModelPreview

## -description
Represents a machine learning model.

## -remarks

## -see-also

## -examples
public async Task LoadModel()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("/Models/image_recognition.pb");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
	
	...
}

