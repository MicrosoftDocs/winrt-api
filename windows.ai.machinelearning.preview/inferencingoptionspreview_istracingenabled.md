---
-api-id: P:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.IsTracingEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsTracingEnabled { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.IsTracingEnabled

## -description
Gets or sets whether tracing is enabled during model evaluation.

## -property-value
True if tracing is enabled; otherwise false. The default value is false.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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
