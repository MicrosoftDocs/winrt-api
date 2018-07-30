---
-api-id: T:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview
-api-type: winrt class
---

<!-- Class syntax.
public class InferencingOptionsPreview : IInferencingOptionsPreview
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview

## -description
Represents the inference options for controlling the evaluation of a model.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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
