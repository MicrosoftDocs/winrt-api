---
-api-id: T:Windows.Media.Devices.MediaCaptureOptimization
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Devices.MediaCaptureOptimization : int
-->

# MediaCaptureOptimization

## -description
Defines the optimizations that the media capture device can use.

## -enum-fields
### -field Default:0
The default driver settings are used.

### -field Quality:1
High picture quality is prioritized.

### -field Latency:2
Low latency is prioritized.

### -field Power:3
Low power consumption is prioritized.

### -field LatencyThenQuality:4
Low latency is prioritized, with high picture quality prioritized second.

### -field LatencyThenPower:5
Low latency is prioritized, with low power consumption prioritized second.

### -field PowerAndQuality:6
Low power consumption and high picture quality are prioritized.


## -remarks

## -examples

## -see-also
[VideoDeviceController::DesiredOptimization](videodevicecontroller_desiredoptimization.md)