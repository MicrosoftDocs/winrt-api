---
-api-id: M:Windows.Devices.Usb.UsbDevice.SendControlInTransferAsync(Windows.Devices.Usb.UsbSetupPacket)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> SendControlInTransferAsync(Windows.Devices.Usb.UsbSetupPacket setupPacket)
-->

# Windows.Devices.Usb.UsbDevice.SendControlInTransferAsync

## -description
Starts a zero-length USB control transfer that reads from the default control endpoint of the device.

## -parameters
### -param setupPacket
A [UsbSetupPacket](usbsetuppacket.md) object that contains the setup packet for the control transfer.

## -returns
Returns an [IAsyncOperation(IBuffer)](../windows.foundation/iasyncoperation_1.md) object that returns the results of the operation.

## -remarks

## -examples

## -see-also
[SendControlInTransferAsync(UsbSetupPacket, IBuffer)](usbdevice_sendcontrolintransferasync_1500240753.md)