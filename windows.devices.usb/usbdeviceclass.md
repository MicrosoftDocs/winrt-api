---
-api-id: T:Windows.Devices.Usb.UsbDeviceClass
-api-type: winrt class
---

<!-- Class syntax.
public class UsbDeviceClass : Windows.Devices.Usb.IUsbDeviceClass
-->

# Windows.Devices.Usb.UsbDeviceClass

## -description
Provides a way for the app to get an Advanced Query Syntax (AQS) string by specifying the class code, subclass code, and the protocol code defined by the device. The properties in this class are passed in the call to [GetDeviceClassSelector](usbdevice_getdeviceclassselector_1975723348.md).

## -remarks
You can create a [UsbDeviceClass](usbdeviceclass.md) object by specifying any one of the following sets of properties:
+ Class code.
+ Class and subclass codes.
+ Class, subclass, and protocol codes.


This code example shows how to specify the device class and subclass codes to obtain a [UsbDevice](usbdevice.md) object.

```csharp
    byte deviceClass = 0xf0;
    byte deviceSubclass = 0x01;
    
    var myDevices = await 
                          Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(
                          UsbDevice.GetDeviceClassSelector(
                          new UsbDeviceClass() {
                          Class = deviceClass, Subclass = deviceSubclass }));

```



## -examples

## -see-also
