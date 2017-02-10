---
-api-id: M:Windows.Devices.Usb.UsbDevice.SendControlOutTransferAsync(Windows.Devices.Usb.UsbSetupPacket,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<uint> SendControlOutTransferAsync(Windows.Devices.Usb.UsbSetupPacket setupPacket, Windows.Storage.Streams.IBuffer buffer)
-->

# Windows.Devices.Usb.UsbDevice.SendControlOutTransferAsync

## -description
Starts a USB control transfer to send data to the default control endpoint of the device.

## -parameters
### -param setupPacket
A [UsbSetupPacket](usbsetuppacket.md) object that contains the setup packet for the control transfer.

### -param buffer
A caller-supplied buffer that contains the transfer data.

## -returns
Returns an [IAsyncOperation(UInt32)](../windows.foundation/iasyncoperation_1.md) object that returns the results of the operation.

## -remarks

## -examples

## -see-also
[SendControlOutTransferAsync(UsbSetupPacket)](usbdevice_sendcontrolouttransferasync_2044496736.md)