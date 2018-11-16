---
-api-id: T:Windows.Devices.Display.Core.DisplayStateFunctionalizeOptions
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum DisplayStateFunctionalizeOptions : uint 
-->

# Windows.Devices.Display.Core.DisplayStateFunctionalizeOptions

## -description
Defines constants that specify options for functionalizing a [DisplayState](displaystate.md) with the system.

## -enum-fields
### -field FailIfStateChanged:1
Indicates that the functionalize operation should fail with [SystemStateChanged](displaystateoperationstatus.md) if the system display state has changed since the [DisplayState](displaystate.md) object was created. This is useful for improving reliability of a functionalize operation because, if it fails for this reason, then it's often better to just redo the entire operation in case the system state change resulted in different availability of modes or monitors.

### -field ValidateTopologyOnly:2
Indicates that the operation should validate whether functionalization will succeed, without updating any [DisplayPath](displaypath.md) properties.

### -field None:0
Indicates no option.

## -remarks

## -see-also

## -examples
