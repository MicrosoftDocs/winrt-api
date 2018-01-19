---
-api-id: T:Windows.AI.MachineLearning.Preview.LearningModelBindingPreview
-api-type: winrt class
---

<!-- Class syntax.
public class LearningModelBindingPreview : ILearningModelBindingPreview, IIterable<Object>>, IMapView<Object>
-->

# Windows.AI.MachineLearning.Preview.LearningModelBindingPreview

## -description
Represents the associations between model inputs and variable instances.

## -remarks

## -see-also

## -examples
public void PrepareBinding(LearningModelPreview model, SoftwareBitmap picture)
{
    // Bind the image
    var binding = new LearningModelBindingPreview(model);
    binding.Bind(_inputImageFeatureName, picture);
}


