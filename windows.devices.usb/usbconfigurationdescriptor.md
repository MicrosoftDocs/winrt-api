---
-api-id: T:Windows.Devices.Usb.UsbConfigurationDescriptor
-api-type: winrt class
---

<!-- Class syntax.
public class UsbConfigurationDescriptor : Windows.Devices.Usb.IUsbConfigurationDescriptor
-->

# Windows.Devices.Usb.UsbConfigurationDescriptor

## -description
Derives information from the first 9 bytes of a USB configuration descriptor. The information includes the power capabilities of the device when the configuration is active and the number of interfaces included in that configuration. For an explanation of a configuration descriptor, Section 9.6.3 Universal Serial Bus Specification. For information about descriptor fields, see:


+ Table 9.15 in the Universal Serial Bus 3.0 Specification
+ Table 9.10 in the Universal Serial Bus Specification (version 2.0)


## -remarks
A USB device exposes its capabilities in the form of a USB configuration. A USB configuration is described in a configuration descriptor that the UsbConfigurationDescriptor class represents. For information about the descriptor, see [USB configuration descriptors](/windows-hardware/drivers/ddi/content/index).

## -examples

## -see-also
[USB configuration descriptors](/windows-hardware/drivers/ddi/content/index)
