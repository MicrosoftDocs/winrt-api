---
-api-id: T:Windows.Devices.Usb.UsbDeviceClasses
-api-type: winrt class
---

<!-- Class syntax.
public class UsbDeviceClasses : Windows.Devices.Usb.IUsbDeviceClasses
-->

# Windows.Devices.Usb.UsbDeviceClasses

## -description

Provides a way for you to retrieve a [UsbDeviceClass](usbdeviceclass.md) object based on the USB device class of a device. The properties defined in this class represent the supported USB device classes, and they return [UsbDeviceClass](usbdeviceclass.md) objects.

For information about USB device classes, see the official USB Website for [Approved Class Specification Documents](https://www.usb.org/documents?search=&type%5B0%5D=55&items_per_page=50).

## -remarks

## -examples

Here's how to specify a specific device class for which to enumerate UsbDevice](usbdevice.md) objects.

```csharp
var myDevices = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(
   Windows.Devices.Usb.UsbDevice.GetDeviceClassSelector(
      Windows.Devices.Usb.UsbDeviceClasses.CdcControl
      ));
```

## -see-also