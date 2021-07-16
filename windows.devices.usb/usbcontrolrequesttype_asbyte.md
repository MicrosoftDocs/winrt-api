---
-api-id: P:Windows.Devices.Usb.UsbControlRequestType.AsByte
-api-type: winrt property
---

<!-- Property syntax
public byte AsByte { get;  set; }
-->

# Windows.Devices.Usb.UsbControlRequestType.AsByte

## -description
Gets or sets the **bmRequestType** value as a byte.

## -property-value
The entire **bmRequestType** value in a byte.

## -remarks
If the hardware specification for the device defines the **bmRequestType** field value to be sent as a byte, you can use the AsByte property. Otherwise, you must individually get or set **bmRequestType** values, such as direction, type, and recipient by using [ControlTransferType](usbcontrolrequesttype_controltransfertype.md), [Direction](usbcontrolrequesttype_direction.md), and [Recipient](usbcontrolrequesttype_recipient.md) properties, respectively.

## -examples

## -see-also
