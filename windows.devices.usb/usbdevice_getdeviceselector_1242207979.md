---
-api-id: M:Windows.Devices.Usb.UsbDevice.GetDeviceSelector(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector(System.UInt32 vendorId, System.UInt32 productId)
-->

# Windows.Devices.Usb.UsbDevice.GetDeviceSelector

## -description
Gets an Advanced Query Syntax (AQS) string, based on vendor and product identifiers, specified by the app. The app passes the string to [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md) in order to find a specific type of USB device.

## -parameters
### -param vendorId
Specifies the vendor identifier for the device as assigned by the USB specification committee. Possible values are 0 through 0xffff.

### -param productId
Specifies the product identifier. This value is assigned by the manufacturer and is device-specific. Possible values are 0 through 0xffff.

## -returns
String formatted as an AQS query.

## -remarks

## -examples

## -see-also
[GetDeviceSelector(UInt32, UInt32, Guid)](usbdevice_getdeviceselector_318985165.md), [GetDeviceSelector(Guid)](usbdevice_getdeviceselector_1740344150.md)