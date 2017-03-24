---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.GetDeviceSelector(System.UInt16,System.UInt16,System.UInt16,System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelector(System.UInt16 usagePage, System.UInt16 usageId, System.UInt16 vendorId, System.UInt16 productId)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.GetDeviceSelector

## -description
Retrieves an Advanced Query Syntax (AQS) string based on the given *usagePage*, *usageId*, *vendorId*, and *productId*.

## -parameters
### -param usagePage
Specifies the usage page of the top-level collection for the given HID device.

### -param usageId
Specifies the usage identifier of the top-level collection for the given HID device.

### -param vendorId
Identifies the device vendor.

### -param productId
Identifies the product.

## -returns
An Advanced Query Syntax (AQS) string that represents a device selector.

## -remarks

## -examples

## -see-also
[GetDeviceSelector(UInt16, UInt16)](hiddevice_getdeviceselector_2035586791.md)