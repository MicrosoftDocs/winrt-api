---
-api-id: M:Windows.Devices.Bluetooth.BluetoothLEDevice.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Bluetooth.BluetoothLEDevice> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.Bluetooth.BluetoothLEDevice.FromIdAsync

## -description
Returns a [BluetoothLEDevice](bluetoothledevice.md) object for the given Id. See **Remarks** in the member topic.

## -parameters

### -param deviceId
The Id of the Bluetooth LE device.

## -returns
After the asynchronous operation completes, returns the [BluetoothLEDevice](bluetoothledevice.md) object with the given Id.

## -remarks
This method must be called from a UI thread.

Creating a [BluetoothLEDevice](bluetoothledevice.md) object by calling this method alone doesn't (necessarily) initiate a connection. To initiate a connection, set [GattSession.MaintainConnection](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattsession.maintainconnection) to `true`, or call an uncached service discovery method on **BluetoothLEDevice**, or perform a read/write operation against the device.

- If **GattSession.MaintainConnection** is set to true, then the system waits indefinitely for a connection, and it will connect when the device is available. There's nothing for your application to wait on, since **GattSession.MaintainConnection** is a property.
- For service discovery and read/write operations in GATT, the system waits a finite but variable time. Anything from instantaneous to a matter of minutes. Factors include the traffic on the stack, and how queued up the request is. If there are no other pending request, and the remote device is unreachable, then the system will wait for 7 seconds before it times out. If there are other pending requests, then each of the requests in the queue can take 7 seconds to process, so the further yours is toward the back of the queue, the longer you'll wait.

Currently, you can't cancel the connection process.

## -examples

## -see-also


## -capabilities
bluetooth
