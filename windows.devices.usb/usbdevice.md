---
-api-id: T:Windows.Devices.Usb.UsbDevice
-api-type: winrt class
---

<!-- Class syntax.
public class UsbDevice : Windows.Devices.Usb.IUsbDevice, Windows.Foundation.IClosable
-->

# Windows.Devices.Usb.UsbDevice

## -description
Represents a USB device. The object provides methods and properties that an app can use to enumerate WinUSB devices and send IN and OUT control transfers.

## -remarks
Before getting a reference to the UsbDevice object, you must have one of these identifiers:
+ The vendor and product identifiers for the physical device. Those identifiers are part of the hardware ID string. Alternatively, you can derive the identifiers from the **Hardware Ids** property in **Device Manager**. For example, if the **Hardware Id** is `USB\VID_045E&PID_078E`, the vendor ID is `0x045E` and product Id is `0x078E`.
+ The device interface [GUID](/windows/win32/api/guiddef/ns-guiddef-guid). You can obtain that GUID from the **DeviceInterfaceGuids** registry entry under: **HKEY_LOCAL_MACHINE**\\**System**\\**CurrentControlSet**\\**Enum**\\**USB**\\**\<Device Identifier\>**\\**\<Instance Identifier\>**\\**Device Parameters**
+ The device's class, subclass, and protocol codes. You can obtain that information from the **CompatibleIds** registry entry, found under the **Device Parameters** key.


To get the UsbDevice object:
1. Get the Advanced Query Syntax (AQS) string that contains search criteria for finding the device in the enumerated device collection. If you want to search by the vendor ID/product ID or the device interface GUID, call [GetDeviceSelector](usbdevice_getdeviceselector_1242207979.md). If you want to search by the device class, call [GetDeviceClassSelector](usbdevice_getdeviceclassselector_1975723348.md). Both calls retrieve formatted AQS strings.
1. Pass the retrieved string to [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md). The call retrieves a [DeviceInformationCollection](../windows.devices.enumeration/deviceinformationcollection.md) object.
1. Loop through the collection. Each iteration gets a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object.
1. Get the [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) property value. The string value is the device instance path. For example, `\\?\USB#VID_045E&PID_078F#6&1b8ff026&0&5#{dee824ef-729b-4a0e-9c14-b7117d33a817}`.
1. Call [FromIdAsync](usbdevice_fromidasync_1322863552.md) by passing the device instance string and get the UsbDevice object.
 You can then use the UsbDevice object to perform other operations, such as sending a control transfer. When the app has finished using the UsbDevice object, the app must release it by calling [Close](usbdevice_close_811482585.md).

## -examples
This example code shows how to get the UsbDevice object by specifying the vendor/product Id.

```csharp
protected override async void OnLaunched(LaunchActivatedEventArgs args)
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
        RequestType = new UsbControlRequestType()
        {
            Recipient = UsbControlRecipient.DefaultInterface,
                                                                
            ControlTransferType = UsbControlTransferType.Vendor 
        }
    };

   await device.SendOutControlTransferAsync(initSetupPacket);
}
```

## -see-also
[Custom USB device sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620530)
