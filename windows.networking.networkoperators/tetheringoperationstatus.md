---
-api-id: T:Windows.Networking.NetworkOperators.TetheringOperationStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.TetheringOperationStatus : int
-->

# TetheringOperationStatus

## -description
Defines the values returned with a [NetworkOperatorTetheringOperationResult](networkoperatortetheringoperationresult.md) object to indicate the status of a tethering operation.

## -enum-fields
### -field Success:0
The operation completed successfully.

### -field Unknown:1
The status of the operation is unknown.

### -field MobileBroadbandDeviceOff:2
The operation could not begin because the mobile broadband device is turned off.

### -field WiFiDeviceOff:3
The operation could not begin because the Wifi device is turned off.

### -field EntitlementCheckTimeout:4
The operation did not complete because the mobile operator could not be contacted to confirm tethering capabilities are provided for this account.

### -field EntitlementCheckFailure:5
The operation did not complete because the account does not currently support tethering operations.

### -field OperationInProgress:6
The operation is still in progress.

### -field BluetoothDeviceOff:7
The operation could not begin because Bluetooth or a required Bluetooth device is turned off.

### -field NetworkLimitedConnectivity:8
The operation did not complete because of limited network connectivity.

### -field AlreadyOn: 9
The hotspot is already on (already running). This status is returned only when calling [StartTetheringAsync](./networkoperatortetheringmanager_starttetheringasync_1060696031.md) with a specified per-session configuration.

### -field RadioRestriction: 10
Can't start a mobile hotspot on the requested frequency band due to radio restrictions (for example, the 6 GHz band requires 2x2 antennae / dual radio).

### -field BandInterference: 11
Can't start a mobile hotspot on the requested frequency band due to the main connection frequency band interfering (for example, the 6 GHz band can't be configured for the mobile hotspot access point if the main station connection is over the 5 GHz band).

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | BluetoothDeviceOff |
| 1607 | 14393 | NetworkLimitedConnectivity |

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
