---
-api-id: T:Windows.Devices.Usb.UsbControlRecipient
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Usb.UsbControlRecipient : int
-->

# UsbControlRecipient

## -description
Defines constants that indicate the recipient of a USB control transfer. The recipient is defined in the setup packet of the control request. See Table 9.2 of section 9.3 of the Universal Serial Bus (USB) specification (www.usb.org).

## -enum-fields
### -field Device:0
The recipient of the control transfer is the device.

### -field SpecifiedInterface:1
The recipient of the control transfer is the USB interface that is specified in the request.

### -field Endpoint:2
The recipient of the control transfer is an endpoint.

### -field Other:3
The recipient of the control transfer is other.

### -field DefaultInterface:4
The recipient of the control transfer is the default (or the first) USB interface in the selected configuration of the device.If the recipient is the first interface of the active configuration ([DefaultInterface](usbdevice_defaultinterface.md)), [SendControlInTransferAsync](usbdevice_sendcontrolintransferasync_609557051.md) and [SendControlOutTransferAsync](usbdevice_sendcontrolouttransferasync_2044496736.md) methods overwrite the low byte of [UsbSetupPacket.Index](usbsetuppacket_index.md) with the interface number of the default interface.

By using this value, an app can omit the interface number in an interface-recipient request.


## -remarks
For conceptual information about USB control transfers, see "About the default endpoint" and "Layout of a control transfer" in [How to send a USB control transfer](/windows-hardware/drivers/ddi/content/index).

## -examples

## -see-also