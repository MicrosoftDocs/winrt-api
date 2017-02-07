---
-api-id: T:Windows.Media.Devices.AudioDeviceRole
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Devices.AudioDeviceRole : int
-->

# AudioDeviceRole

## -description
Indicates the role of an audio device.

## -enum-fields
### -field Default:0
The audio device is used in the default role.

### -field Communications:1
The audio device is used for communications.


## -remarks
The [AudioDeviceRole](audiodevicerole.md) enumeration is used by the [GetDefaultAudioCaptureId](mediadevice_getdefaultaudiocaptureid.md) and [GetDefaultAudioRenderId](mediadevice_getdefaultaudiorenderid.md) methods to specify the type of default audio device for capture or rendering.

## -examples

## -see-also