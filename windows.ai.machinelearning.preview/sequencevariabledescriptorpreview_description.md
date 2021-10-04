---
-api-id: P:Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.Description
-api-type: winrt property
---

<!-- Property syntax.
public string Description { get; }
-->

# Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.Description

## -description
**Deprecated.** Gets the description of the sequence variable.

## -property-value
The description of the sequence variable.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples

 ```csharp
public void Evaluator(LearningModelPreview model)
{
	// Retrieve the first input feature which is a Sequence
    ILearningModelVariableDescriptorPreview inputSequenceFeatureDescription = model.Description.InputFeatures.FirstOrDefault(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Image);
 
    SequenceVariableDescriptorPreview SequenceDescriptor = (SequenceVariableDescriptorPreview)inputSequenceFeatureDescription;

	// Output the description of the Sequence variable
    Console.WriteLine($"Input Feature Name: {SequenceDescriptor.Name}. Description: {SequenceDescriptor.Description}.");

 }
 ```

