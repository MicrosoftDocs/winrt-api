---
-api-id: M:Windows.Devices.Usb.UsbDevice.SendControlOutTransferAsync(Windows.Devices.Usb.UsbSetupPacket)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<uint> SendControlOutTransferAsync(Windows.Devices.Usb.UsbSetupPacket setupPacket)
-->

# Windows.Devices.Usb.UsbDevice.SendControlOutTransferAsync

## -description
Starts a zero-length USB control transfer that writes to the default control endpoint of the device.

## -parameters
### -param setupPacket
A [UsbSetupPacket](usbsetuppacket.md) object that contains the setup packet for the control transfer.

## -returns
Returns an [IAsyncOperation(UInt32)](../windows.foundation/iasyncoperation_1.md) object that returns the results of the operation.

## -remarks

## -examples

## -see-also
[SendControlOutTransferAsync(UsbSetupPacket, IBuffer)](usbdevice_sendcontrolouttransferasync_81938988.md)