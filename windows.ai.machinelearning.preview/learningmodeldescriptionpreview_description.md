---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Description
-api-type: winrt property
---

<!-- Property syntax.
public string Description { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Description

## -description
Gets the custom description of the model.

## -property-value
The custom description of the model.

## -remarks

## -see-also

## -examples
void Evaluator(LearningModelPreview model)
{
    if (model.Description.Description != "This is a custom description")
    {
        throw new Exception("Invalid model description");
    }
}


