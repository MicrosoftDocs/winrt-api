---
-api-id: T:Windows.Media.Devices.InfraredTorchMode
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum InfraredTorchMode : int 
-->

# Windows.Media.Devices.InfraredTorchMode

## -description
Defines the Infrared torch modes.

## -enum-fields
### -field On:1
“On” mode means that the infrared LED is constantly on

### -field Off:0
“Off” mode means that the infrared LED is constantly off

### -field AlternatingFrameIllumination:2
“AlternatingFrameIllumination” mode means that the infrared LED is on for every other frame.

## -remarks
Set the current infrared torch mode with the [InfraredTorchControl.CurrentMode](infraredtorchcontrol_currentmode.md)

Not all modes may be available on all devices. Check the [InfraredTorchControl.SupportedModes](infraredtorchcontrol_supportedmodes.md) property to determine what modes are supported on the current device.

## -see-also
[InfraredTorchControl](infraredtorchcontrol.md)

## -examples

