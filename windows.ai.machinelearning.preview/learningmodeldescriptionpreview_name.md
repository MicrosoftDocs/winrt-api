---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Name

## -description
Gets the name of the model.

## -property-value
The name of the model.

## -remarks

## -see-also

## -examples
void Evaluator(LearningModelPreview model)
{
    if (model.Description.Name != "Image_Recognition")
    {
        throw new Exception("Invalid model name");
    }
}


