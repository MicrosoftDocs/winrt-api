---
-api-id: T:Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeStatus : int
-->

# PerceptionFrameSourcePropertyChangeStatus

## -description
Indicates the status of a property change that an app requested of a frame source.

## -enum-fields
### -field Unknown:0
The status change is unknown.

### -field Accepted:1
The requested property change was accepted by the frame source.

### -field LostControl:2
The frame source property could not be changed because the app lost controller mode before the request was processed.

### -field PropertyNotSupported:3
The requested property is not supported by the frame source.

### -field PropertyReadOnly:4
The requested property change was not accepted because the property is read-only.

### -field ValueOutOfRange:5
The requested property change was not accepted because the value is not in a valid range.


## -remarks

## -examples

## -see-also