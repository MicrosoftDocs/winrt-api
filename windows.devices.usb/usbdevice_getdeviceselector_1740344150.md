---
-api-id: M:Windows.Devices.Usb.UsbDevice.GetDeviceSelector(System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector(System.Guid winUsbInterfaceClass)
-->

# Windows.Devices.Usb.UsbDevice.GetDeviceSelector

## -description
Gets an Advanced Query Syntax (AQS) string, based on the device interface GUID identifier, specified by the app. The app passes the string to [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) in order to find a specific type of USB device.



## -parameters
### -param winUsbInterfaceClass
The device interface GUID exposed by the Winusb.sys driver. See the remarks section.

## -returns
String formatted as an AQS query.

## -remarks
You can obtain the device interface GUID from the **DeviceInterfaceGuids** registry entry under this key:**HKEY_LOCAL_MACHINE**\**System**\**CurrentControlSet**\**Enum**\**USB**\***&lt;Device Identifier&gt;***\***&lt;Instance Identifier&gt;***\**Device Parameters**

## -examples

## -see-also
[GetDeviceSelector(UInt32, UInt32, Guid)](usbdevice_getdeviceselector_318985165.md), [GetDeviceSelector(UInt32, UInt32)](usbdevice_getdeviceselector_1242207979.md)