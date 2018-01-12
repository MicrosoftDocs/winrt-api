---
-api-id: M:Windows.AI.MachineLearning.Preview.ILearningModelPreview.EvaluateFeaturesAsync(Windows.Foundation.Collections.IMap{System.String,System.Object},System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ILearningModelEvaluationResultPreview> ILearningModelPreview.EvaluateFeaturesAsync(IMap<Object> features, String correlationId)
-->

# Windows.AI.MachineLearning.Preview.ILearningModelPreview.EvaluateFeaturesAsync

## -description
Asynchronously evaluates the model against the provided inputs.

## -parameters
### -param features
The features to bind as inputs.

### -param correlationId

## -returns
The evaluation result.

## -remarks
Prior to evaluation, this method performs and internal check onn feature constraints and binds the features as inputs. This is an alternative separately binding then evaluating the model, streamlining the validation and creation of workspace resources.

## -see-also

## -examples

