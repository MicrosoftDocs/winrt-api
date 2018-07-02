---
-api-id: M:Windows.AI.MachineLearning.LearningModelSession.EvaluateFeaturesAsync(Windows.Foundation.Collections.IMap{System.String,System.Object},System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<LearningModelEvaluationResult> LearningModelSession.EvaluateFeaturesAsync(IMap<Object> features, String correlationId)
-->

# Windows.AI.MachineLearning.LearningModelSession.EvaluateFeaturesAsync

## -description
Asynchronously evaluate the machine learning model using the feature values in the map 'features'.
## -parameters
### -param features

### -param correlationId
Optional user supplied string that was attached to the Evaluate() call to connect the output results.
## -returns

## -remarks
This method is an alternative to the separated bind then evaluate form that takes a LearningModelBinding. It will take the passed in features, create a LearningModelBinding for you, bind the features, and then evaluate the model.
## -see-also

## -examples
