---
-api-id: M:Windows.AI.MachineLearning.Preview.LearningModelPreview.LoadModelFromStorageFileAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ILearningModelPreview> LearningModelPreview.LoadModelFromStorageFileAsync(IStorageFile modelFile)
-->

# Windows.AI.MachineLearning.Preview.LearningModelPreview.LoadModelFromStorageFileAsync

## -description
**Deprecated.** Asynchronously loads a model from file storage.

## -parameters
### -param modelFile
The location of the model file.  

## -returns
Returns a LearningModelPreview.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public async Task LoadModel()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.onnx");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
}
 ```

