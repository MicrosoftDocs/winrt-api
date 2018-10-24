---
-api-id: T:Windows.Devices.HumanInterfaceDevice.HidCollectionType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.HumanInterfaceDevice.HidCollectionType : int
-->

# HidCollectionType

## -description
Identifies the relationship that defines a grouping of controls on the device.

Collections are a way to group a set of controls that are similar to one another; or, are related by physical, or, operational proximity.

## -enum-fields
### -field Physical:0
The controls are related by physical source.

### -field Application:1
The controls are related by intended application.

### -field Logical:2
The controls are logically related.

### -field Report:3
The controls are related by report type.

### -field NamedArray:4
The controls are related by a named array.

### -field UsageSwitch:5
The controls are related by a usage switch.

### -field UsageModifier:6
The controls are related by a usage modifier.

### -field Other:7
The control relationship is not described by a defined category.


## -remarks

## -examples

## -see-also

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
