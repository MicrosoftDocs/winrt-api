---
-api-id: T:Windows.Devices.Usb.UsbTransferDirection
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Usb.UsbTransferDirection : int
-->

# UsbTransferDirection

## -description
Defines constants that indicate the direction of USB transfer: IN or OUT transfers.

## -enum-fields
### -field Out:0
Indicates an OUT transfer from the host to the device.

### -field In:1
Indicates an IN transfer from the device to the host.


## -remarks
The direction of a USB transfer is determined from the host side and not the target USB device. In an IN transfer, data moves from the device to the host. In an OUT transfer, data moves from the host to the device.

## -examples

## -see-also