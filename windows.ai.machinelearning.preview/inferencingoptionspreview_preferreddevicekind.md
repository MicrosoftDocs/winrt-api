---
-api-id: P:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.PreferredDeviceKind
-api-type: winrt property
---

<!-- Property syntax.
public LearningModelDeviceKindPreview PreferredDeviceKind { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.PreferredDeviceKind

## -description
Gets or sets the preferred device that the evaluation will be performed on.

## -property-value
The preferred device. The default value is LearningDeviceAny.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

## -see-also

## -examples
 ```csharp
public void SetEvaluationOptionsForModel(LearningModelPreview model)
{
    // Set our preference to use the GPU
    InferencingOptionsPreview options = model.InferencingOptions;
    options.PreferredDeviceKind = LearningModelDeviceKindPreview.LearningDeviceGpu;
 
    model.InferencingOptions = options;
}
```