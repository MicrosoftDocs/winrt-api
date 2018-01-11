---
-api-id: T:Windows.Media.Devices.HdrVideoMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Devices.HdrVideoMode : int
-->

# HdrVideoMode

## -description
Defines the High Dynamic Range (HDR) video modes.

## -enum-fields
### -field Off:0
HDR video capture is disabled.

### -field On:1
HDR video capture is enabled.

### -field Auto:2
The system dynamically enables HDR video capture when appropriate.


## -remarks
Set the temporal denoising mode with the [HdrVideoControl.Mode](hdrvideocontrol_mode.md) property.

Not all modes may be available on all devices. Check the [HdrVideoControl.SupportedModes](hdrvideocontrol_supportedmodes.md) property to determine what modes are supported on the current device.


## -examples

## -see-also
[HdrVideoControl](hdrvideocontrol.md)