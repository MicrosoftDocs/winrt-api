---
-api-id: M:Windows.AI.MachineLearning.LearningModelSession.EvaluateFeaturesAsync(Windows.Foundation.Collections.IMap{System.String,System.Object},System.String)
-api-type: winrt method
ROBOTS: NOFOLLOW, NOINDEX
---

<!-- Method syntax.
public IAsyncOperation<LearningModelEvaluationResult> LearningModelSession.EvaluateFeaturesAsync(IMap<Object> features, String correlationId)
-->

# Windows.AI.MachineLearning.LearningModelSession.EvaluateFeaturesAsync

## -description

> [!IMPORTANT]
> For the latest documentation about Windows Machine Learning, see [What is Windows ML](/windows/ai/new-windows-ml/overview). That documentation describes APIs that are in the **Microsoft.Windows.AI.MachineLearning** namespace, which ships in the Windows App SDK. Those APIs supersede the ones documented here, which are in the **Windows.AI.MachineLearning** namespace, and were shipped in 2018.

Asynchronously evaluate the machine learning model using the feature values in *features*.

## -parameters
### -param features
A map of features with which to evaluate the model.

### -param correlationId
Optional user supplied string to connect the output results.

## -returns
The result of the evaluation.

## -remarks
This method is an alternative to the separated bind then evaluate form that takes a [LearningModelBinding](learningmodelbinding.md). It will take the passed in features, create a **LearningModelBinding** for you, bind the features, and then evaluate the model.

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also

## -examples
