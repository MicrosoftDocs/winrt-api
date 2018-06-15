---
-api-id: P:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.ReclaimMemoryAfterEvaluation
-api-type: winrt property
---

<!-- Property syntax.
public bool ReclaimMemoryAfterEvaluation { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.ReclaimMemoryAfterEvaluation

## -description
Gets or sets whether to reclaim allocated memory after the model evaluation.

## -property-value
True if reclaiming allocated memory after evaluation; otherwise false. The default value is false.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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

