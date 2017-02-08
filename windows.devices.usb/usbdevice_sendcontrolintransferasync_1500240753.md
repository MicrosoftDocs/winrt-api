---
-api-id: M:Windows.Devices.Usb.UsbDevice.SendControlInTransferAsync(Windows.Devices.Usb.UsbSetupPacket,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> SendControlInTransferAsync(Windows.Devices.Usb.UsbSetupPacket setupPacket, Windows.Storage.Streams.IBuffer buffer)
-->

# Windows.Devices.Usb.UsbDevice.SendControlInTransferAsync

## -description
Starts a USB control transfer to receive data from the default control endpoint of the device.

## -parameters
### -param setupPacket
A [UsbSetupPacket](usbsetuppacket.md) object that contains the setup packet for the control transfer.

### -param buffer
A caller-supplied buffer that contains transfer data.

## -returns
Returns an [IAsyncOperation(IBuffer)](../windows.foundation/iasyncoperation_1.md) object that returns the results of the operation.

## -remarks

## -examples

## -see-also
