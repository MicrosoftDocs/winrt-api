---
-api-id: M:Windows.AI.MachineLearning.Preview.LearningModelPreview.LoadModelFromStorageFileAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ILearningModelPreview> LearningModelPreview.LoadModelFromStorageFileAsync(IStorageFile modelFile)
-->

# Windows.AI.MachineLearning.Preview.LearningModelPreview.LoadModelFromStorageFileAsync

## -description
Asynchronously loads a model from file storage.

## -parameters
### -param modelFile
The location of the model file.  

## -returns

## -remarks

## -see-also

## -examples
public async Task LoadModel()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("/Models/image_recognition.pb");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
}


