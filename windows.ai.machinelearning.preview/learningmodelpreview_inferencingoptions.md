---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelPreview.InferencingOptions
-api-type: winrt property
---

<!-- Property syntax.
public IInferencingOptionsPreview InferencingOptions { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelPreview.InferencingOptions

## -description
**Deprecated.** Gets or sets the inferencing options for the evaluation of a model.

## -property-value
The inferencing options for the evaluation of a model.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public async Task LoadModelAsync()
{
	// Load Model
    var modelFile = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync("model.onnx");
    LearningModelPreview model = await LearningModelPreview.LoadModelFromStorageFileAsync(modelFile);


	//Set inferencing options to use GPU
	InferencingOptionsPreview options = model.InferencingOptions;
	options.PreferredDeviceKind = LearningModelDeviceKindPreview.LearningDeviceCpu;
	model.InferencingOptions = options;
}
 ```