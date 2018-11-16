---
-api-id: P:Windows.AI.MachineLearning.LearningModel.Author
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public string Author { get; }
-->

# Windows.AI.MachineLearning.LearningModel.Author

## -description
The name of the model author.

## -property-value
The name of the model author.

## -remarks

## -see-also

## -examples
The following example loads a model from a local file, outputs the model author to the application's UI, and creates a session from the model.

```csharp
private async Task LoadModelAsync(string _modelFileName)
{
    LearningModel _model;
    LearningModelSession _session;

    try
    {
        // Load and create the model
        var modelFile = 
            await StorageFile.GetFileFromApplicationUriAsync(new Uri($"ms-appx:///Assets/{_modelFileName}"));
        _model = await LearningModel.LoadFromStorageFileAsync(modelFile);

        //Output the model author to application UI
        StatusBlock.Text = $"Model Author: {_model.Author}";

        // Create the evaluation session with the model
        _session = new LearningModelSession(_model);

    }
    catch (Exception ex)
    {
        StatusBlock.Text = $"error: {ex.Message}";
        _model = null;
    }
}
```
