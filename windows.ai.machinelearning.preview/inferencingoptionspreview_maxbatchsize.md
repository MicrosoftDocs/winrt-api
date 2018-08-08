---
-api-id: P:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.MaxBatchSize
-api-type: winrt property
---

<!-- Property syntax.
public int MaxBatchSize { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.MaxBatchSize

## -description
**Deprecated.** Gets or sets the maximum batch size for model evaluation.

## -property-value
The maximum batch size. Preview API only supports batching size of 1. 

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void SetEvaluationOptionsForModel(LearningModelPreview model)
{
    InferencingOptionsPreview options = model.InferencingOptions;
    options.MaxBatchSize = 2;
 
    model.InferencingOptions = options;
}

```