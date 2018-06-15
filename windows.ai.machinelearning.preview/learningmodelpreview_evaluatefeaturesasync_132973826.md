---
-api-id: M:Windows.AI.MachineLearning.Preview.LearningModelPreview.EvaluateFeaturesAsync(Windows.Foundation.Collections.IMap{System.String,System.Object},System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ILearningModelEvaluationResultPreview> LearningModelPreview.EvaluateFeaturesAsync(IMap<Object> features, String correlationId)
-->

# Windows.AI.MachineLearning.Preview.LearningModelPreview.EvaluateFeaturesAsync

## -description
Asynchronously evaluates names variable instances as the inputs and outputs for the model.

## -parameters
### -param features
The features to bind as inputs.

### -param correlationId
The value to correlate the evaluation with the output results.

## -returns
The evaluation result.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

Prior to evaluation, this method performs and internal check onn feature constraints and binds the features as inputs. This is an alternative separately binding then evaluating the model, streamlining the validation and creation of workspace resources.


## -see-also

## -examples

