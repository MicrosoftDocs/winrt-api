---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Domain
-api-type: winrt property
---

<!-- Property syntax.
public string Domain { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Domain

## -description
Gets the domain information for the model.

## -property-value
The domain information for the model.

## -remarks

## -see-also

## -examples
void Evaluator(LearningModelPreview model)
{
    if (model.Description.Domain != "test_domain")
    {
        throw new Exception("Invalid model domain");
    }
}


