---
-api-id: P:Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.Name
-api-type: winrt property
---

<!-- Property syntax.
public string Name { get; }
-->

# Windows.AI.MachineLearning.Preview.SequenceVariableDescriptorPreview.Name

## -description
Gets the name of the sequence variable.

## -property-value
The name of the sequence variable. This must be unique across all variables in the model.

## -remarks

## -see-also

> [!NOTE]
> Windows.AI.MachineLearning.Preview is a preview API and may be substantially modified before it’s officially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.

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