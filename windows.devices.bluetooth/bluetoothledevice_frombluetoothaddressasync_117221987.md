---
-api-id: M:Windows.Devices.Bluetooth.BluetoothLEDevice.FromBluetoothAddressAsync(System.UInt64)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Bluetooth.BluetoothLEDevice> FromBluetoothAddressAsync(System.UInt64 bluetoothAddress)
-->

# Windows.Devices.Bluetooth.BluetoothLEDevice.FromBluetoothAddressAsync

## -description
Returns a [BluetoothLEDevice](bluetoothledevice.md) object representing the peer Bluetooth LE device with the given address. See **Remarks** (in this member topic).

## -parameters

### -param bluetoothAddress
A [BluetoothAddress](bluetoothledevice_bluetoothaddress.md) value containing the 64-bit address of the peer Bluetooth LE device.

## -returns
Returns an object representing an asynchronous operation. When that object completes, it contains a [BluetoothLEDevice](bluetoothledevice.md) object representing the peer Bluetooth LE device with the given address.

> [!IMPORTANT]
> The returned **BluetoothLEDevice** is set to `null` if **FromBluetoothAddressAsync** can't find the device identified by *bluetoothAddress*. Specifically, if the device isn't paired and it isn't found in the system cache. You can populate the cache for a non-paired device using either the LE advertisement watcher APIs ([BluetoothLEAdvertisementWatcher](/uwp/api/windows.devices.bluetooth.advertisement.bluetoothleadvertisementwatcher)) or the device enumeration APIs ([GetDeviceSelectorFromPairingState](/uwp/api/windows.devices.bluetooth.bluetoothledevice.getdeviceselectorfrompairingstate)) to scan for the Bluetooth devices before the **FromBluetoothAddressAsync** can be successfully used.

## -remarks
Creating a [BluetoothLEDevice](bluetoothledevice.md) object by calling this method alone doesn't (necessarily) initiate a connection. To initiate a connection, set [GattSession.MaintainConnection](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattsession.maintainconnection) to `true`, or call an uncached service discovery method on **BluetoothLEDevice**, or perform a read/write operation against the device.

- If **GattSession.MaintainConnection** is set to true, then the system waits indefinitely for a connection, and it will connect when the device is available. There's nothing for your application to wait on, since **GattSession.MaintainConnection** is a property.
- For service discovery and read/write operations in GATT, the system waits a finite but variable time. Anything from instantaneous to a matter of minutes. Factors include the traffic on the stack, and how queued up the request is. If there are no other pending request, and the remote device is unreachable, then the system will wait for 7 seconds before it times out. If there are other pending requests, then each of the requests in the queue can take 7 seconds to process, so the further yours is toward the back of the queue, the longer you'll wait.

You can't cancel the connection process.

## -examples

## -see-also
[FromBluetoothAddressAsync(UInt64, BluetoothAddressType)](bluetoothledevice_frombluetoothaddressasync_613922801.md)

## -capabilities
bluetooth