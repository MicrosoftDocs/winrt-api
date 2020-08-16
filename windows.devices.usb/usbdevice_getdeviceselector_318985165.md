---
-api-id: M:Windows.Devices.Usb.UsbDevice.GetDeviceSelector(System.UInt32,System.UInt32,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector(System.UInt32 vendorId, System.UInt32 productId, System.Guid winUsbInterfaceClass)
-->

# Windows.Devices.Usb.UsbDevice.GetDeviceSelector

## -description
Gets an Advanced Query Syntax (AQS) string, based on vendor, product, and device interface [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) identifiers, specified by the app. The app passes the string to [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) in order to find a specific type of USB device.

## -parameters
### -param vendorId
Specifies the vendor identifier for the device as assigned by the USB specification committee. Possible values are 0 through 0xffff.

### -param productId
Specifies the product identifier. This value is assigned by the manufacturer and is device-specific. Possible values are 0 through 0xffff.

### -param winUsbInterfaceClass
The device interface GUID exposed by the Winusb.sys driver. See the remarks section.

## -returns
String formatted as an AQS query.

## -remarks
You can obtain the device interface GUID from the **DeviceInterfaceGuids** registry entry under this key:**HKEY_LOCAL_MACHINE**\**System**\**CurrentControlSet**\**Enum**\**USB**\***&lt;Device Identifier&gt;***\***&lt;Instance Identifier&gt;***\**Device Parameters**

## -examples

## -see-also
[GetDeviceSelector(Guid)](usbdevice_getdeviceselector_1740344150.md), [GetDeviceSelector(UInt32, UInt32)](usbdevice_getdeviceselector_1242207979.md)