---
-api-id: T:Windows.Devices.Usb.UsbDevice
-api-type: winrt class
---

<!-- Class syntax.
public class UsbDevice : Windows.Devices.Usb.IUsbDevice, Windows.Foundation.IClosable
-->

# Windows.Devices.Usb.UsbDevice

## -description
Represents a USB device. The object provides methods and properties that an app can use to find the device (in the system) with which the app wants to communicate, and sends IN and OUT control transfers to the device.

## -remarks
Before getting a reference to the [UsbDevice](usbdevice.md) object, you must have one of these identifiers:
+ The vendor and product identifiers for the physical device. Those identifiers are part of the hardware ID string. You can obtain that string from the [Models](https://docs.microsoft.com/en-us/windows-hardware/drivers/install/inf-models-section) section in the INF file. Alternatively, if WinUSB was loaded based on the compatible ID specified in the device descriptor, you can derive the identifiers from the **Hardware Ids** property in **Device Manager**. For example, if **Hardware Id** is "USB\VID_045E&amp;PID_078E", vendor ID is "0x045E" and product Id is "0x078E".
+ The device interface GUID. You can obtain that GUID from the **DeviceInterfaceGuids** registry entry under this key:**HKEY_LOCAL_MACHINE**\**System**\**CurrentControlSet**\**Enum**\**USB**\***&lt;Device Identifier&gt;***\***&lt;Instance Identifier&gt;***\**Device Parameters**
+ The device's class, subclass, and protocol codes. You can obtain that information from the **CompatibleIds** registry entry, found under the **Device Parameters** key.


To get the [UsbDevice](usbdevice.md) object:
1. Get the Advanced Query Syntax (AQS) string that contains search criteria for finding the device in the enumerated device collection. If you want to search by the vendor ID/product ID or the device interface GUID, call [GetDeviceSelector](usbdevice_getdeviceselector.md). If you want to search by the device class, call [GetDeviceClassSelector](usbdevice_getdeviceclassselector.md). Both calls retrieve formatted AQS strings.
1. Pass the retrieved string to [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md). The call retrieves a [DeviceInformationCollection](../windows.devices.enumeration/deviceinformationcollection.md) object.
1. Loop through the collection. Each iteration gets a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object.
1. Get the [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) property value. The string value is the device instance path. For example, "\\\\?\\USB#VID_045E&amp;PID_078F#6&amp;1b8ff026&amp;0&amp;5#{dee824ef-729b-4a0e-9c14-b7117d33a817}".
1. Call [FromIdAsync](usbdevice_fromidasync.md) by passing the device instance string and get the [UsbDevice](usbdevice.md) object.
 You can then use the [UsbDevice](usbdevice.md) object to perform other operations, such as sending a control transfer. When the app has finished using the [UsbDevice](usbdevice.md) object, the app must release it by calling [Close](usbdevice_close.md).

## -examples
This example code shows how to get the [UsbDevice](usbdevice.md) object by specifying the vendor/product Id or the device interface GUID.

```csharp
protected override async void OnLaunched1(LaunchActivatedEventArgs args)
{
    UInt32 vid = 0x045E;
    UInt32 pid = 0x078F;

    string aqs = UsbDevice.GetDeviceSelector(vid, pid);
    
    var myDevices = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(aqs, null);
            
    if (myDevices.Count == 0)
    {
        ShowError("Device not found!");
        return;
    }

    UsbDevice device = await UsbDevice.FromIdAsync(myDevices[0].Id);

   // Send a control transfer. 
            
   UsbSetupPacket initSetupPacket = new UsbSetupPacket() 
   { 
       Request = initRequest,
       RequestType = new UsbControlRequestType() { 

           Recipient = UsbControlRecipient.DefaultInterface,
                                                            
           ControlTransferType = UsbControlTransferType.Vendor 
       } 
   };
            
   await device.SendOutControlTransferAsync(initSetupPacket);

}
```



## -see-also
[IClosable](../windows.foundation/iclosable.md), [Custom USB device sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620530)