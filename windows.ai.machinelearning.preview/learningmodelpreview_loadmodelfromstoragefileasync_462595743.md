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
Returns a LearningModelPreview.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

## -see-also

## -examples
 ```csharp
public async Task LoadModel()
{
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.onnx");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);
}
 ```

