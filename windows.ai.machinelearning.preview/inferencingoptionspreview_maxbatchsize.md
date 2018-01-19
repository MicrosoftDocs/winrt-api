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
The maximum batch size. The default value is 1. 

## -remarks

## -see-also

## -examples
public void SetEvaluationOptionsForModel(LearningModelPreview model)
{
    InferencingOptionsPreview options = model.InferencingOptions;
    options.MaxBatchSize = 2;
 
    model.InferencingOptions = options;
}

