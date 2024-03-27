---
-api-id: P:Windows.Devices.Enumeration.DevicePairingSetMembersRequestedEventArgs.PairingSetMembers
-api-type: winrt property
---

# Windows.Devices.Enumeration.DevicePairingSetMembersRequestedEventArgs.PairingSetMembers

<!--
public System.Collections.Generic.IReadOnlyList<Windows.Devices.Enumeration.DeviceInformation> PairingSetMembers { get; }
-->


## -description

Gets a vector of the devices/endpoints that were added to the set, or that failed to be added to the set, depending on the value of [Status](./devicepairingsetmembersrequestedeventargs_status.md). For more info, and code examples, see [Pairing a set with the DeviceInformationPairing.Custom property](/windows/uwp/devices-sensors/pairing-a-set).

## -property-value

A vector of the devices/endpoints that were added to the set, or that failed to be added to the set, depending on the value of [Status](./devicepairingsetmembersrequestedeventargs_status.md).

## -remarks

In the case of Bluetooth LE, if you'd paired the left earbud, then **PairingSetMembers** would contain the device info object for the right earbud.

In the case of IPP, if you'd called the [DeviceInformationCustomPairing.AddPairingSetMember](./deviceinformationcustompairing_addpairingsetmember_1277113744.md) method, then **PairingSetMembers** would contain a vector of all of the set members that you'd added. If pairing has started on the primary device/endpoint, then this vector will just have one device in it. If you added N devices/endpoints before starting pairing the primary, then the vector will have N devices in it.

If some devices fail to add, then your [DeviceInformationCustomPairing.PairingSetMembersRequested](./deviceinformationcustompairing_pairingsetmembersrequested.md) handler will still be called with a vector of the failed devices/endpoints. If, for example WSD adds and eSCL fails, then the handler will be called twice&mdash;once with success and the WSD endpoint in the vector; and again with failure and eSCL in the vector. The idea is that your app probably still wants to pair it even if the device failed to be added into the set.

## -see-also

[Pairing a set with the DeviceInformationPairing.Custom property](/windows/uwp/devices-sensors/pairing-a-set)
