---
-api-id: M:Windows.Devices.SerialCommunication.SerialDevice.GetDeviceSelectorFromUsbVidPid(System.UInt16,System.UInt16)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelectorFromUsbVidPid(System.UInt16 vendorId, System.UInt16 productId)
-->

# Windows.Devices.SerialCommunication.SerialDevice.GetDeviceSelectorFromUsbVidPid

## -description
Gets an Advanced Query Syntax (AQS) string that the app can pass to [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) in order to find a specific Serial-to-USB device by specifying its VID and PID.

## -parameters
### -param vendorId
Specifies the vendor identifier for the device as assigned by the USB specification committee. Possible values are 0 through 0xffff.

### -param productId
Specifies the product identifier. This value is assigned by the manufacturer and is device-specific. Possible values are 0 through 0xffff.

## -returns
String formatted as an AQS query.

## -remarks

## -examples
This example code shows how to get the [SerialDevice](serialdevice.md) object by specifying the vendor/product Id of the Serial-to-USB device.

```csharp


protected override async void OnLaunched1(LaunchActivatedEventArgs args)
{
    UInt32 vid = 0x045E;
    UInt32 pid = 0x078F;
    
    string aqs = SerialDevice.GetDeviceSelectorFromUsbVidPid(vid, pid);
    
    var myDevices = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(aqs, null);
            
    if (myDevices.Count == 0)
    {
        ShowError("Device not found!");
        return;
    }

    using SerialDevice device = await SerialDevice.FromIdAsync(myDevices[0].Id);

}



```



## -see-also
