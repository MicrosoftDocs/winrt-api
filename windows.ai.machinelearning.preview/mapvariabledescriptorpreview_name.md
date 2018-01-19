---
-api-id: P:Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview.Name

## -description
Gets the name of the map variable.

## -property-value
The name of the map variable. This must be unique across all variables in the model.

## -remarks

## -see-also

## -examples
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is a map
    ILearningModelVariableDescriptorPreview inputMapFeatureDescription = model.Description.InputFeatures.First(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Map);
 
    MapVariableDescriptorPreview MapDescriptor = (MapVariableDescriptorPreview)inputMapFeatureDescription;

	// Ensure the input feature name is expected
    if (MapDescriptor.Name != "Expected_Map_Variable_Name)
    {
        throw new Exception("Invalid feature name");
    }

 }


