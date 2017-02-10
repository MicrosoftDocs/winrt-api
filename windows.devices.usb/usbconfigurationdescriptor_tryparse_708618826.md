---
-api-id: M:Windows.Devices.Usb.UsbConfigurationDescriptor.TryParse(Windows.Devices.Usb.UsbDescriptor,Windows.Devices.Usb.UsbConfigurationDescriptor@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryParse(Windows.Devices.Usb.UsbDescriptor descriptor, Windows.Devices.Usb.UsbConfigurationDescriptor parsed)
-->

# Windows.Devices.Usb.UsbConfigurationDescriptor.TryParse

## -description
Retrieves the first 9 bytes of a USB configuration descriptor in a [UsbConfigurationDescriptor](usbconfigurationdescriptor.md) object that is contained in a [UsbDescriptor](usbdescriptor.md) object.

## -parameters
### -param descriptor
The [UsbDescriptor](usbdescriptor.md) object to parse.

### -param parsed
Receives a [UsbConfigurationDescriptor](usbconfigurationdescriptor.md) object.

## -returns
True, if a [UsbConfigurationDescriptor](usbconfigurationdescriptor.md) object was found in the specified [UsbDescriptor](usbdescriptor.md) object. Otherwise, false.

## -remarks

## -examples

## -see-also
