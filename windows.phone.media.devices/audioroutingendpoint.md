---
-api-id: T:Windows.Phone.Media.Devices.AudioRoutingEndpoint
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Phone.Media.Devices.AudioRoutingEndpoint : int
-->

# AudioRoutingEndpoint

## -description
Lists the audio endpoints that can be explicitly set.

## -enum-fields
### -field Default:0
The default audio endpoint. The default endpoint is a wired headset, if available; otherwise, the handset.

### -field Earpiece:1
An earpiece.

### -field Speakerphone:2
The speakerphone.

### -field Bluetooth:3
A Bluetooth device.

### -field WiredHeadset:4
A wired headset.

### -field WiredHeadsetSpeakerOnly:5
A wired headset for output only; the input is received from the default microphone.

### -field BluetoothWithNoiseAndEchoCancellation:6
A Bluetooth device with noise and echo cancellation.

### -field BluetoothPreferred:7
A Bluetooth device is preferred.


## -remarks
Note that the options in this list are not the same as in the [AvailableAudioRoutingEndpoints](availableaudioroutingendpoints.md) enumeration. Some audio endpoints, such as a wired headset, cannot be set by software.

The APIs in the [Windows.Phone.Media.Devices](windows_phone_media_devices.md) namespace require the ID_CAP_VOIP or ID_CAP_VOICEMAIL capability.

## -examples

## -see-also


## -capabilities
ID_CAP_VOIP [Windows Phone]