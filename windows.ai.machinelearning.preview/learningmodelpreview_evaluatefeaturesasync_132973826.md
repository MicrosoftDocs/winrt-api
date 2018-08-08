---
-api-id: M:Windows.AI.MachineLearning.Preview.LearningModelPreview.EvaluateFeaturesAsync(Windows.Foundation.Collections.IMap{System.String,System.Object},System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ILearningModelEvaluationResultPreview> LearningModelPreview.EvaluateFeaturesAsync(IMap<Object> features, String correlationId)
-->

# Windows.AI.MachineLearning.Preview.LearningModelPreview.EvaluateFeaturesAsync

## -description
**Deprecated.** Asynchronously evaluates names variable instances as the inputs and outputs for the model.

## -parameters
### -param features
The features to bind as inputs.

### -param correlationId
The value to correlate the evaluation with the output results.

## -returns
The evaluation result.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

Prior to evaluation, this method performs and internal check onn feature constraints and binds the features as inputs. This is an alternative separately binding then evaluating the model, streamlining the validation and creation of workspace resources.


## -see-also

## -examples

