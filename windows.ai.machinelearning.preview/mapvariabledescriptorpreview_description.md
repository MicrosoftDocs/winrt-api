---
-api-id: P:Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview.Description
-api-type: winrt property
---

<!-- Property syntax.
public string Description { get; }
-->

# Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview.Description

## -description
Gets the description map variable.

## -property-value
The description of the map variable.

## -remarks

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

## -see-also

## -examples
 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is a map
    ILearningModelVariableDescriptorPreview inputMapFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    MapVariableDescriptorPreview mapDescriptor = (MapVariableDescriptorPreview)inputMapFeatureDescription;

	// Output the description of the map variable
    Console.WriteLine($"Input Feature Name: {mapDescriptor.Name}. Description: {mapDescriptor.Description}.");

 }
 ```