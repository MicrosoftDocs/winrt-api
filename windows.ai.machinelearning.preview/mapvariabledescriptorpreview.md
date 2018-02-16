---
-api-id: T:Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview
-api-type: winrt class
---

<!-- Class syntax.
public class MapVariableDescriptorPreview : ILearningModelVariableDescriptorPreview, IMapVariableDescriptorPreview
-->

# Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview

## -description
Represents the map variable descriptor information.

## -remarks

## -see-also

## -examples
 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is a map
    ILearningModelVariableDescriptorPreview inputMapFeatureDescription = model.Description.InputFeatures.First(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Map);
 
    MapVariableDescriptorPreview MapDescriptor = (MapVariableDescriptorPreview)inputMapFeatureDescription;

	// Ensure the input feature is of type map
    if (MapDescriptor.ModelFeatureKind != LearningModelFeatureKindPreview.Map)
    {
        Console.WriteLine($"Input Feature Name: {imageDescriptor.Name}. Not a map feature type.);
    }

 }
 ```
