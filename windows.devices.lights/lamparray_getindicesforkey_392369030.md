---
-api-id: M:Windows.Devices.Lights.LampArray.GetIndicesForKey(Windows.System.VirtualKey)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public int[] LampArray.GetIndicesForKey(VirtualKey key)
-->

# Windows.Devices.Lights.LampArray.GetIndicesForKey

## -description
Searches for all lamp indices that are bound to the specific [VirtualKey](../windows.system/virtualkey.md)

## -parameters
### -param key
The [VirtualKey](../windows.system/virtualkey.md).

## -returns
Array of all lamp indices that are bound to the specific [VirtualKey](../windows.system/virtualkey.md).  Array is empty if no lamp indices are found bound to the [VirtualKey](../windows.system/virtualkey.md).

## -remarks
Lamp indices can be (optionally) bound by the device to only a single key.  A [VirtualKey](../windows.system/virtualkey.md) may have 1 or more indices bound to it.

## -see-also

## -examples

