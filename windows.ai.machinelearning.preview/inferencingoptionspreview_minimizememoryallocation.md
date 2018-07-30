---
-api-id: P:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.MinimizeMemoryAllocation
-api-type: winrt property
---

<!-- Property syntax.
public bool MinimizeMemoryAllocation { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.MinimizeMemoryAllocation

## -description
Gets or sets whether to minimize memory allocation after model evaluation.

## -property-value
True if minimizing memory allocation during evaluation; otherwise false. The default is false.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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
