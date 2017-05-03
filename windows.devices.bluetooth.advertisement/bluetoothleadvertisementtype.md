---
-api-id: T:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementType : int
-->

# BluetoothLEAdvertisementType

## -description
Specifies the different types of Bluetooth LE advertisement payloads.

## -enum-fields
### -field ConnectableUndirected:0
The advertisement is undirected and indicates that the device is connectable and scannable. This advertisement type can carry data.

This corresponds with the ADV_IND type defined in the Bluetooth LE specifications.

### -field ConnectableDirected:1
The advertisement is directed and indicates that the device is connectable but not scannable. This advertisement type cannot carry data.

This corresponds with the ADV_DIRECT_IND type defined in the Bluetooth LE specifications.

### -field ScannableUndirected:2
The advertisement is undirected and indicates that the device is scannable but not connectable. This advertisement type can carry data.

This corresponds with the ADV_SCAN_IND type defined in the Bluetooth LE specifications.

### -field NonConnectableUndirected:3
The advertisement is undirected and indicates that the device is not connectable nor scannable. This advertisement type can carry data.

This corresponds with the ADV_NONCONN_IND type defined in the Bluetooth LE specifications.

### -field ScanResponse:4
This advertisement is a scan response to a scan request issued for a scannable advertisement. This advertisement type can carry data.

This corresponds with the SCAN_RSP type defined in the Bluetooth LE specifications.


## -remarks

## -examples

## -see-also