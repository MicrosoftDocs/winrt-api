---
-api-id: T:Windows.Devices.Enumeration.DevicePairingResultStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Enumeration.DevicePairingResultStatus : int
-->

# DevicePairingResultStatus

## -description
The result of the pairing action with an Association Endpoint (AEP) device object. For more information about AEP objects, see [DeviceInformationKind](deviceinformationkind.md).

## -enum-fields
### -field Paired:0
The device object is now paired.

### -field NotReadyToPair:1
The device object is not in a state where it can be paired.

### -field NotPaired:2
The device object is not currently paired.

### -field AlreadyPaired:3
The device object has already been paired.

### -field ConnectionRejected:4
The device object rejected the connection.

### -field TooManyConnections:5
The device object indicated it cannot accept any more incoming connections.

### -field HardwareFailure:6
The device object indicated there was a hardware failure.

### -field AuthenticationTimeout:7
The authentication process timed out before it could complete.

### -field AuthenticationNotAllowed:8
The authentication protocol is not supported, so the device is not paired.

### -field AuthenticationFailure:9
Authentication failed, so the device is not paired. Either the device object or the application rejected the authentication.

### -field NoSupportedProfiles:10
There are no network profiles for this device object to use.

### -field ProtectionLevelCouldNotBeMet:11
The minimum level of protection is not supported by the device object or the application.

### -field AccessDenied:12
Your application does not have the appropriate permissions level to pair the device object.

### -field InvalidCeremonyData:13
The ceremony data was incorrect.

### -field PairingCanceled:14
The pairing action was canceled before completion.

### -field OperationAlreadyInProgress:15
The device object is already attempting to pair or unpair.

### -field RequiredHandlerNotRegistered:16
Either the event handler wasn't registered or a required [DevicePairingKinds](devicepairingkinds.md) was not supported.

### -field RejectedByHandler:17
The application handler rejected the pairing.

### -field RemoteDeviceHasAssociation:18
The remove device already has an association.

### -field Failed:19
An unknown failure occurred.


## -remarks

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | Failed |
| 1511 | 10586 | OperationAlreadyInProgress |
| 1511 | 10586 | PairingCanceled |
| 1511 | 10586 | RejectedByHandler |
| 1511 | 10586 | RemoteDeviceHasAssociation |
| 1511 | 10586 | RequiredHandlerNotRegistered |

## -examples

## -see-also
