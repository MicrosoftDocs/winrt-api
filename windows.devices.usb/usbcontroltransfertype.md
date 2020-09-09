---
-api-id: T:Windows.Devices.Usb.UsbControlTransferType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Usb.UsbControlTransferType : int
-->

# UsbControlTransferType

## -description
Defines constants that indicate the type of USB control transfer: standard, class, or vendor.

## -enum-fields
### -field Standard:0
Indicates a standard USB control request that the app can send to obtain information about the device, its configurations, interfaces, and endpoints. The standard requests are described in section 9.4 of the Universal Serial Bus (USB) specification (www.usb.org).

### -field Class:1
Indicates a class-specific USB control request described by a specific device class specification.

### -field Vendor:2
Indicates a vendor-specified USB control request and depends on the requests supported by the device.


## -remarks
For conceptual information about USB control transfers, see "Microsoft-defined methods for sending control transfer requests" in [How to send a USB control transfer](/windows-hardware/drivers/ddi/content/index).

## -examples

## -see-also