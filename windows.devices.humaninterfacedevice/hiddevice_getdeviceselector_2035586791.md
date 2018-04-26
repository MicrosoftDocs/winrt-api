---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.GetDeviceSelector(System.UInt16,System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelector(System.UInt16 usagePage, System.UInt16 usageId)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.GetDeviceSelector

## -description
Retrieves an Advanced Query Syntax (AQS) string based on the given *usagePage* and *usageId*.

## -parameters
### -param usagePage
Specifies the usage page of the top-level collection for the given HID device.

### -param usageId
Specifies the usage identifier of the top-level collection for the given HID device.

## -returns
An Advanced Query Syntax (AQS) string that represents a device selector.

## -remarks

## -examples

## -see-also

### Reference

[GetDeviceSelector(UInt16, UInt16, UInt16, UInt16)](hiddevice_getdeviceselector_1541481733.md)

### Samples

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
