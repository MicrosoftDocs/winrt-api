---
-api-id: P:Windows.Devices.Usb.UsbControlRequestType.Recipient
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Usb.UsbControlRecipient Recipient { get;  set; }
-->

# Windows.Devices.Usb.UsbControlRequestType.Recipient

## -description
Gets or sets the recipient of the USB control transfer.

## -property-value
The recipient of the USB control transfer.

## -remarks
If the recipient is the first interface of the active configuration ([DefaultInterface](usbdevice_defaultinterface.md)), [SendControlInTransferAsync](usbdevice_sendcontrolintransferasync_609557051.md) and [SendControlOutTransferAsync](usbdevice_sendcontrolouttransferasync_2044496736.md) methods overwrite the low byte of [UsbSetupPacket.Index](usbsetuppacket_index.md) with the interface number of the default interface.

## -examples

## -see-also
