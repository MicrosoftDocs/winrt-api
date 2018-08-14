---
-api-id: P:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.IsTracingEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsTracingEnabled { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.IsTracingEnabled

## -description
**Deprecated.** Gets or sets whether tracing is enabled during model evaluation.

## -property-value
True if tracing is enabled; otherwise false. The default value is false.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void SetEvaluationOptionsForModel(LearningModelPreview model)
{
    InferencingOptionsPreview options = model.InferencingOptions;
    options.IsTracingEnabled = true;
 
    model.InferencingOptions = options;
}
```
