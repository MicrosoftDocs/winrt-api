---
-api-id: P:Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview.ModelFeatureKind
-api-type: winrt property
---

<!-- Property syntax.
public LearningModelFeatureKindPreview ModelFeatureKind { get; }
-->

# Windows.AI.MachineLearning.Preview.MapVariableDescriptorPreview.ModelFeatureKind

## -description
**Deprecated.** Gets the data type of the variable.

## -property-value
The data type of the variable.

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

	// Ensure the input feature is of type map
    if (MapDescriptor.ModelFeatureKind != LearningModelFeatureKindPreview.Map)
    {
        Console.WriteLine($"Input Feature Name: {MapDescriptor.Name}. Feature type is not a map.");
    }

 }
 ```
