---
-api-id: T:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview
-api-type: winrt class
---

<!-- Class syntax.
public class InferencingOptionsPreview : IInferencingOptionsPreview
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview

## -description
**Deprecated.** Represents the inference options for controlling the evaluation of a model.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
void SetEvaluationOptionsForModel(LearningModelPreview model)
{
    // Set our preference to use the GPU
    InferencingOptionsPreview options = model.InferencingOptions;
    options.PreferredDeviceKind = LearningModelDeviceKindPreview.LearningDeviceGpu;
 
    model.InferencingOptions = options;
}

```
