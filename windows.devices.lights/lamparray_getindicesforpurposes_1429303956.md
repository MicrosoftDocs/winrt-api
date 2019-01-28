---
-api-id: M:Windows.Devices.Lights.LampArray.GetIndicesForPurposes(Windows.Devices.Lights.LampPurposes)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public int[] LampArray.GetIndicesForPurposes(LampPurposes purposes)
-->

# Windows.Devices.Lights.LampArray.GetIndicesForPurposes

## -description
Searches for all lamp indices that are bound to the specified [LampPurposes](lamppurposes.md).

## -parameters
### -param purposes
The [LampPurposes](lamppurposes.md).

## -returns
Array of all lamp indices that are bound to the specific [LampPurposes](lamppurposes.md).  Array is empty if no lamp indices are found bound to the [LampPurposes](lamppurposes.md).

## -remarks
Lamp indices can be (optionally) bound by the device to multiple [LampPurposes](lamppurposes.md).

## -see-also

## -examples

