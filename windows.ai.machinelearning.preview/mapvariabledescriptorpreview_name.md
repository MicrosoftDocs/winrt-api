---
-api-id: P:Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview.Name

## -description
**Deprecated.** Gets the name of the map variable.

## -property-value
The name of the map variable. This must be unique across all variables in the model.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

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
