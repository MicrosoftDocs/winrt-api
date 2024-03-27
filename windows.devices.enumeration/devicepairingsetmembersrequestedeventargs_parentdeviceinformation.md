---
-api-id: P:Windows.Devices.Enumeration.DevicePairingSetMembersRequestedEventArgs.ParentDeviceInformation
-api-type: winrt property
---

# Windows.Devices.Enumeration.DevicePairingSetMembersRequestedEventArgs.ParentDeviceInformation

<!--
public Windows.Devices.Enumeration.DeviceInformation ParentDeviceInformation { get; }
-->


## -description

Gets the primary device/endpoint of the set. For more info, and code examples, see [Pairing a set with the DeviceInformationPairing.Custom property](/windows/uwp/devices-sensors/pairing-a-set).

## -property-value

An object representing the primary device/endpoint of the set.

## -remarks

In the case of Bluetooth LE, if you'd started by pairing the left earbud, then **ParentDeviceInformation** would be that earbud.

In the case of IPP, if you'd you started pairing the WSD device (and added the others), then **ParentDeviceInformation** would be the WSD device.

## -see-also

[Pairing a set with the DeviceInformationPairing.Custom property](/windows/uwp/devices-sensors/pairing-a-set)
