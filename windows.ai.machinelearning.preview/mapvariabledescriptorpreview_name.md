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

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

## -see-also

## -examples
 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is a map
    ILearningModelVariableDescriptorPreview inputMapFeatureDescription = model.Description.InputFeatures.First(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Map);
 
    MapVariableDescriptorPreview MapDescriptor = (MapVariableDescriptorPreview)inputMapFeatureDescription;

	// Output the description of the map variable
    Console.WriteLine($"Input Feature Name: {MapDescriptor.Name}. Description: {MapDescriptor.Description}.");
 }
 ```
