---
-api-id: T:Windows.Devices.Sensors.SimpleOrientation
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Sensors.SimpleOrientation : int
-->

# SimpleOrientation

## -description
Indicates the orientation of the device.

## -enum-fields
### -field NotRotated:0
The device is not rotated.

### -field Rotated90DegreesCounterclockwise:1
The device is rotated 90-degrees counter-clockwise.

### -field Rotated180DegreesCounterclockwise:2
The device is rotated 180-degrees counter-clockwise.

### -field Rotated270DegreesCounterclockwise:3
The device is rotated 270-degrees counter-clockwise.

### -field Faceup:4
The device is face-up and the display is visible to the user.

### -field Facedown:5
The device is face-down and the display is hidden from the user.


## -remarks
The **Faceup** and **Facedown** values are supported for tablet devices. You can use them to support power management: As long as the orientation is **Faceup**, your application will continue to run; but, once the orientation is **Facedown**, your application can pause or enter "sleep mode".

## -examples

## -see-also