---
-api-id: M:Windows.Devices.Usb.UsbDevice.GetDeviceClassSelector(Windows.Devices.Usb.UsbDeviceClass)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceClassSelector(Windows.Devices.Usb.UsbDeviceClass usbClass)
-->

# Windows.Devices.Usb.UsbDevice.GetDeviceClassSelector

## -description
Gets an Advanced Query Syntax (AQS) string that the app can pass to [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md) in order to find a specific type of USB device.

## -parameters
### -param usbClass
A [UsbDeviceClass](usbdeviceclass.md) object for the device class specified by the app.

## -returns
String formatted as an AQS query.

## -remarks
You can search for a [UsbDevice](usbdevice.md) in the enumerated collection of devices by specifying class code, sub class code, or protocol code. To do this,
1. Create a [UsbDeviceClass](usbdeviceclass.md) object by specifying [ClassCode](usbdeviceclass_classcode.md), [SubclassCode](usbdeviceclass_subclasscode.md), and [ProtocolCode](usbdeviceclass_protocolcode.md) property values. Alternatively, you can call the constructor by specifying a particular [UsbDeviceClasses](usbdeviceclasses.md) property.
1. Call [GetDeviceClassSelector](usbdevice_getdeviceclassselector.md) and pass that new class. The call retrieves an AQS string.
1. Call [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md) and pass the string to get the [UsbDevice](usbdevice.md) object.


## -examples
```csharp
protected override async void OnLaunched(LaunchActivatedEventArgs args)
{
    byte deviceClass = 0xf0;
    byte deviceSubclass = 0x01;
    
    var myDevices = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(
                          UsbDevice.GetDeviceClassSelector(
                          new UsbDeviceClass() {
                          Class = deviceClass, Subclass = deviceSubclass }));

    UsbDevice device = null;

    foreach (var device in myDevices)
    {
        if (IsMyDevice(device))
        {
            device = await UsbDevice.FromIdAsync(device.Id);
        }
    }

    if (device == null)
    {
        ShowError("Usb device not found");
        return;
    }

}
```



## -see-also
