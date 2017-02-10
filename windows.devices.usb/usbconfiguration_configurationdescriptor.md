---
-api-id: P:Windows.Devices.Usb.UsbConfiguration.ConfigurationDescriptor
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Usb.UsbConfigurationDescriptor ConfigurationDescriptor { get; }
-->

# Windows.Devices.Usb.UsbConfiguration.ConfigurationDescriptor

## -description
Gets the object that contains the first 9 bytes of the descriptor associated with the USB configuration.

## -property-value
A [UsbConfigurationDescriptor](usbconfigurationdescriptor.md) object that represents the first 9 bytes of the descriptor associated with the USB configuration.

## -remarks
The received [UsbConfigurationDescriptor](usbconfigurationdescriptor.md) object represents only the first 9 bytes of the configuration descriptor. To get the entire set of descriptors associated with a USB configuration, use the Descriptors property that gets the array of all descriptors within the configuration.

## -examples

## -see-also
