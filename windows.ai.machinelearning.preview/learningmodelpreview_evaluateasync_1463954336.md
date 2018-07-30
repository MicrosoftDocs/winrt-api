---
-api-id: M:Windows.AI.MachineLearning.Preview.LearningModelPreview.EvaluateAsync(Windows.AI.MachineLearning.Preview.ILearningModelBindingPreview,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ILearningModelEvaluationResultPreview> LearningModelPreview.EvaluateAsync(ILearningModelBindingPreview binding, String correlationId)
-->

# Windows.AI.MachineLearning.Preview.LearningModelPreview.EvaluateAsync

## -description
Asynchronously evaluates the model against the provided bound inputs and outputs.

## -parameters
### -param binding
The binding containing the associations between model inputs, outputs, and variable instances. 

### -param correlationId
The value to correlate the evaluation with the output results.

## -returns
The evaluation result.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

## -see-also

## -examples
 ```csharp
public async Task Evaluate(LearningModelPreview model, SoftwareBitmap picture, List<Int64> outputLabelList)
{
	ImageVariableDescriptorPreview inputImageDescription;
	TensorVariableDescriptorPreview outputTensorDescription;

	List<ILearningModelVariableDescriptorPreview> inputFeatures = model.Description.InputFeatures.ToList();
	List<ILearningModelVariableDescriptorPreview> outputFeatures = model.Description.OutputFeatures.ToList();

    inputImageDescription =
         inputFeatures.FirstOrDefault(feature => feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image)
         as ImageVariableDescriptorPreview;
	outputTensorDescription =
         outputFeatures.FirstOrDefault(feature => feature.ModelFeatureKind == LearningModelFeatureKindPreview.Tensor)
         as TensorVariableDescriptorPreview;


    // Bind the inputs and outputs
    var binding = new LearningModelBindingPreview(model);
    binding.Bind(inputImageDescription, picture);
	binding.Bind(outputTensorDescription.Name, _outputLabelList);


	//Evaluate the model
	var results = await _model.EvaluateAsync(binding, "test");
}
 ```
