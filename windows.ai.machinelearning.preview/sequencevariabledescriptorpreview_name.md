---
-api-id: P:Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.Name

## -description
**Deprecated.** Gets the name of the sequence variable.

## -property-value
The name of the sequence variable. This must be unique across all variables in the model.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is a sequence variable
    ILearningModelVariableDescriptorPreview inputSequenceFeatureDescription = model.Description.InputFeatures.First(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Sequence);
 
    SequenceVariableDescriptorPreview SequenceDescriptor = (SequenceVariableDescriptorPreview)inputSequenceFeatureDescription;

	// Output the description of the Sequence variable
    Console.WriteLine($"Input Feature Name: {SequenceDescriptor.Name}. Description: {SequenceDescriptor.Description}.");
 }
 ```