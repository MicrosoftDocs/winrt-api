---
-api-id: P:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.ReclaimMemoryAfterEvaluation
-api-type: winrt property
---

<!-- Property syntax.
public bool ReclaimMemoryAfterEvaluation { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.ReclaimMemoryAfterEvaluation

## -description
**Deprecated.** Gets or sets whether to reclaim allocated memory after the model evaluation.

## -property-value
True if reclaiming allocated memory after evaluation; otherwise false. The default value is false.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void SetEvaluationOptionsForModel(LearningModelPreview model)
{
    InferencingOptionsPreview options = model.InferencingOptions;
    options.ReclaimMemoryAfterEvaluation = true;
 
    model.InferencingOptions = options;
}
```

