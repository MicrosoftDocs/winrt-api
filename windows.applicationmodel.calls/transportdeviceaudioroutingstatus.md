---
-api-id: T:Windows.ApplicationModel.Calls.TransportDeviceAudioRoutingStatus
-api-type: winrt enum
---

# Windows.ApplicationModel.Calls.TransportDeviceAudioRoutingStatus

<!--
public enum TransportDeviceAudioRoutingStatus
-->

## -description

Defines constants that specify the audio routing status of an underlying transport device.

## -enum-fields

### -field Unknown: 0

Specifies that the audio routing status is unknown. You can use the remote device (Phone) instead for the outgoing call being placed.

### -field CanRouteToLocalDevice: 1

Specifies that the audio *can* be routed to the local device.

### -field CannotRouteToLocalDevice: 2

Specifies that the audio *can't* be routed to the local device. You can use the remote device (Phone) instead for the outgoing call being placed.

## -remarks

## -see-also

## -examples

## -capabilities
phoneCall
