---
-api-id: P:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.MinimizeMemoryAllocation
-api-type: winrt property
---

<!-- Property syntax.
public bool MinimizeMemoryAllocation { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.MinimizeMemoryAllocation

## -description
**Deprecated.** Gets or sets whether to minimize memory allocation after model evaluation.

## -property-value
True if minimizing memory allocation during evaluation; otherwise false. The default is false.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void SetEvaluationOptionsForModel(LearningModelPreview model)
{
    InferencingOptionsPreview options = model.InferencingOptions;
    options.MinimizeMemoryAllocation = true;
 
    model.InferencingOptions = options;
}
```
