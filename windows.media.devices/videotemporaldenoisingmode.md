---
-api-id: T:Windows.Media.Devices.VideoTemporalDenoisingMode
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum VideoTemporalDenoisingMode : int 
-->

# Windows.Media.Devices.VideoTemporalDenoisingMode

## -description
Defines the video temporal denoising modes.

## -enum-fields
### -field On:1
Temporal denoising is on.

### -field Off:0
Temporal denoising is off.

### -field Auto:2
The system dynamically enables temporal denoising when appropriate.

## -remarks
Set the temporal denoising mode with the [VideoTemporalDenoisingControl.Mode](videotemporaldenoisingcontrol_mode.md) property.

Not all modes may be available on all devices. Check the [VideoTemporalDenoisingControl.SupportedModes](videotemporaldenoisingcontrol_supportedmodes.md) property to determine what modes are supported on the current device.

## -see-also

## -examples

