---
-api-id: T:Windows.Devices.Usb.UsbConfiguration
-api-type: winrt class
---

<!-- Class syntax.
public class UsbConfiguration : Windows.Devices.Usb.IUsbConfiguration
-->

# Windows.Devices.Usb.UsbConfiguration

## -description
Provides information about a USB configuration, its descriptors and the interfaces defined within that configuration. For an explanation of a USB configuration, see Section 9.6.3 in the Universal Serial Bus (USB) specification.

## -remarks
Within a USB configuration, the number of interfaces and their alternate settings are variable, depending on the number of interfaces that the device supports. You can collect all that information by using: [UsbConfigurationDescriptor](usbconfigurationdescriptor.md) and [UsbConfigurationDescriptor.Descriptors](usbconfiguration_descriptors.md). The [UsbConfigurationDescriptor](usbconfigurationdescriptor.md) contains the first 9 bytes of the configuration descriptor. The [UsbConfigurationDescriptor.Descriptors](usbconfiguration_descriptors.md) object contains an array of descriptors associated with all interfaces and their settings.

## -examples

## -see-also
