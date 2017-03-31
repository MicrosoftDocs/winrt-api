---
-api-id: T:Windows.Devices.PointOfService.UnifiedPosHealthCheckLevel
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.UnifiedPosHealthCheckLevel : int
-->

# UnifiedPosHealthCheckLevel

## -description
Defines the constants that indicates the type of health check that can be performed on the devices.

## -enum-fields
### -field UnknownHealthCheckLevel:0
Perform an unspecified test.

### -field POSInternal:1
Perform internal tests to that do not physically change the device.

### -field External:2
Perform a more thorough test that may change the device.

### -field Interactive:3
Perform a interactive test of the device. The supporting service object will typically display a modal dialog box to present test options and results.


## -remarks

## -examples

## -see-also