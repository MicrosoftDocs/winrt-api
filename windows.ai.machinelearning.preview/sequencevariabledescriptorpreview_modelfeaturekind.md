---
-api-id: P:Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.ModelFeatureKind
-api-type: winrt property
---

<!-- Property syntax.
public LearningModelFeatureKindPreview ModelFeatureKind { get; }
-->

# Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.ModelFeatureKind

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
	// Retrieve the first input feature which is a sequence variable
    ILearningModelVariableDescriptorPreview inputSequenceFeatureDescription = model.Description.InputFeatures.First(feature=>feature.ModelFeatureKind == LearningModelFeatureKindPreview.Sequence);
 
    SequenceVariableDescriptorPreview SequenceDescriptor = (SequenceVariableDescriptorPreview)inputSequenceFeatureDescription;

	// Ensure the input feature is of type Sequence
    if (SequenceDescriptor.ModelFeatureKind != LearningModelFeatureKindPreview.Sequence)
    {
        Console.WriteLine($"Input Feature Name: {SequenceDescriptor.Name}. Feature type is not a Sequence.");
    }

 }
 ```

