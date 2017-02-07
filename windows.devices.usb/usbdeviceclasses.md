---
-api-id: T:Windows.Devices.Usb.UsbDeviceClasses
-api-type: winrt class
---

<!-- Class syntax.
public class UsbDeviceClasses : Windows.Devices.Usb.IUsbDeviceClasses
-->

# Windows.Devices.Usb.UsbDeviceClasses

## -description
Provides a way for the app to create a [UsbDeviceClass](usbdeviceclass.md) object by specifying the USB device class of the device. The properties defined in this class represent the supported USB device classes and are passed in the constructor call to instantiate [UsbDeviceClass](usbdeviceclass.md). For information about USB device classes, see the official USB Website for [ Approved Class Specification Documents](http://www.usb.org/developers/docs/devclass_docs/).

## -remarks

## -examples
This code example shows how to specify a specific device class to obtain a [UsbDevice](usbdevice.md) object.

```csharp
    
    var myDevices = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(
                          UsbDevice.GetDeviceClassSelector(
                          new UsbDeviceClass(UsbDeviceClasses.CdcControl) {}));

```



## -see-also