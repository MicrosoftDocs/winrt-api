---
-api-id: T:Windows.AI.MachineLearning.LearningModelDeviceKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum LearningModelDeviceKind : int
-->

# Windows.AI.MachineLearning.LearningModelDeviceKind

## -description
Defines the list of device kinds that can evaluate a machine learning model. 
## -enum-fields
### -field DirectXMinPower:4
Use the system policy defined device for minimum power.
### -field DirectXHighPerformance:3
Use the system policy defined device for high performance.
### -field DirectX:2
Use a GPU or other DirectX device to evaluate the model.
### -field Default:0
Let the system decide which device to use.
### -field Cpu:1
Use the CPU to evaluate the model.
## -remarks
If not specified, the system will decide which device to use.
## -see-also

## -examples
