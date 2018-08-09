---
-api-id: T:Windows.AI.MachineLearning.Preview.LearningModelDeviceKindPreview
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum LearningModelDeviceKindPreview : int 
-->

# Windows.AI.MachineLearning.Preview.LearningModelDeviceKindPreview

## -description
**Deprecated.** Defines the list of constants representing Windows Machine Learning supported device kinds.

## -enum-fields
### -field LearningDeviceNpu:3
A neural processor.

### -field LearningDeviceGpu:2
A graphics processor.

### -field LearningDeviceFpga:5
A field-programmable gate array.
### -field LearningDeviceDsp:4
A digital signal proccesor.

### -field LearningDeviceCpu:1
A central processor.

### -field LearningDeviceAny:0
The defualt value. Any device.

## -remarks

> [!Warning]
> This is a deprecated API. Please use the [Windows.AI.MachineLearning](../windows.ai.machinelearning/windows_ai_machinelearning.md) namespace instead.

## -see-also

## -examples
 ```csharp
void SetEvaluationOptionsForModel(LearningModelPreview model)
{
    // Set our preference to use the GPU
    InferencingOptionsPreview options = model.InferencingOptions;
    options.PreferredDeviceKind = LearningModelDeviceKindPreview.LearningDeviceGpu;
 
    model.InferencingOptions = options;
}
 ```