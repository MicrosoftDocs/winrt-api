---
-api-id: T:Windows.Phone.Media.Devices.AvailableAudioRoutingEndpoints
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Phone.Media.Devices.AvailableAudioRoutingEndpoints : uint
-->

# AvailableAudioRoutingEndpoints

## -description
Indicates which audio endpoints are available.

## -enum-fields
### -field None:0
No audio endpoints are available.

### -field Earpiece:1
An earpiece is available.

### -field Speakerphone:2
The speakerphone is available.

### -field Bluetooth:4
A Bluetooth device is available.


## -remarks
Note that the options in this list are not the same as in the [AudioRoutingEndpoints](availableaudioroutingendpoints.md) enumeration. Some audio endpoints, such as a wired headset, cannot be set by software.

## -examples

## -see-also


## -capabilities
ID_CAP_VOIP [Windows Phone]