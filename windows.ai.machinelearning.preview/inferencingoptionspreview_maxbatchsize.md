---
-api-id: P:Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.MaxBatchSize
-api-type: winrt property
---

<!-- Property syntax.
public int MaxBatchSize { get;  set; }
-->

# Windows.AI.MachineLearning.Preview.InferencingOptionsPreview.MaxBatchSize

## -description
Gets or sets the maximum batch size for model evaluation.

## -property-value
The maximum batch size. Preview API only supports batching size of 1. 

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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