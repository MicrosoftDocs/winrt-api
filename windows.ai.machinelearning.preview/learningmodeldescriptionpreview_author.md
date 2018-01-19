---
-api-id: P:Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Author
-api-type: winrt property
---

<!-- Property syntax.
public string Author { get; }
-->

# Windows.AI.MachineLearning.Preview.LearningModelDescriptionPreview.Author

## -description
Gets the author information from model.

## -property-value
The author information from the model.

## -remarks

## -see-also

## -examples
void Evaluator(LearningModelPreview model)
{
    if (model.Description.Author != "Nick")
    {
        throw new Exception("Invalid model author");
    }
}

