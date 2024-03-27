---
-api-id: T:Windows.Devices.Enumeration.DevicePairingAddPairingSetMemberStatus
-api-type: winrt enum
---

# Windows.Devices.Enumeration.DevicePairingAddPairingSetMemberStatus

<!--
public enum DevicePairingAddPairingSetMemberStatus
-->


## -description

Defines constants that specify a status value describing the result of adding member(s) to a pairing set. For more info, and code examples, see [Pairing a set with the DeviceInformationPairing.Custom property](/windows/uwp/devices-sensors/pairing-a-set). See [DevicePairingSetMembersRequestedEventArgs.Status](./devicepairingsetmembersrequestedeventargs_status.md).

## -enum-fields

### -field AddedToSet: 0

Specifies that set member(s) were added successfully to the set. This status applies to a call to [DeviceInformationCustomPairing.AddPairingSetMember](./deviceinformationcustompairing_addpairingsetmember_1277113744.md), and indicates that you can expect *the successfully added set member(s)* to be in the [DevicePairingSetMembersRequestedEventArgs.PairingSetMembers](./devicepairingsetmembersrequestedeventargs_pairingsetmembers.md) vector.

### -field CouldNotBeAddedToSet: 1

Specifies that set member(s) couldn't be added to the set. This status applies to a call to [DeviceInformationCustomPairing.AddPairingSetMember](./deviceinformationcustompairing_addpairingsetmember_1277113744.md), and indicates that you can expect *the set member(s) that couldn't be added* to be in the [DevicePairingSetMembersRequestedEventArgs.PairingSetMembers](./devicepairingsetmembersrequestedeventargs_pairingsetmembers.md) vector.

### -field SetDiscoveryNotAttemptedByProtocol: 2

Specifies that the protocol didn't attempt to discover set members. The protocol probably doesn't support it.

### -field SetDiscoveryCompletedByProtocol: 3

Specifies that the protocol successfully enumerated all set members. No further discovery will happen.

### -field SetDiscoveryPartiallyCompletedByProtocol: 4

Specifies that the protocol discovered some set members, but not all of them. No further discovery will happen.

### -field Failed: 5

Specifies that an unknown failure occurred, for which we have no mapping.

## -remarks

## -see-also

[DevicePairingSetMembersRequestedEventArgs.Status](./devicepairingsetmembersrequestedeventargs_status.md), [Pairing a set with the DeviceInformationPairing.Custom property](/windows/uwp/devices-sensors/pairing-a-set)
