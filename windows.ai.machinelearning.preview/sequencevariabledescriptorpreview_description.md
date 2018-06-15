---
-api-id: P:Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.Description
-api-type: winrt property
---

<!-- Property syntax.
public string Description { get; }
-->

# Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.Description

## -description
Gets the description of the sequence variable.

## -property-value
The description of the sequence variable.

## -remarks

## -see-also

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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

