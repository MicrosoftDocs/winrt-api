---
-api-id: T:Windows.Devices.Enumeration.DevicePairingSetMembersRequestedEventArgs
-api-type: winrt class
---

# Windows.Devices.Enumeration.DevicePairingSetMembersRequestedEventArgs

<!--
public sealed class DevicePairingSetMembersRequestedEventArgs
-->


## -description

Event arguments passed to your handler for the [DeviceInformationCustomPairing.PairingSetMembersRequested](./deviceinformationcustompairing_pairingsetmembersrequested.md) event, which is raised when the member(s) of a pairing set have been requested.

**DevicePairingSetMembersRequestedEventArgs** contains: a status indicating success or failure; a vector of the devices/endpoints that were added to the set, or that failed to be added to the set, depending on that status; and info about the parent device.

For more info, and code examples, see [Pairing a set with the DeviceInformationPairing.Custom property](/windows/uwp/devices-sensors/pairing-a-set).

## -remarks

## -see-also

[Pairing a set with the DeviceInformationPairing.Custom property](/windows/uwp/devices-sensors/pairing-a-set)
