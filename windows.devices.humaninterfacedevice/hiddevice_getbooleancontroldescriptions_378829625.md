---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.GetBooleanControlDescriptions(Windows.Devices.HumanInterfaceDevice.HidReportType,System.UInt16,System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.HumanInterfaceDevice.HidBooleanControlDescription> GetBooleanControlDescriptions(Windows.Devices.HumanInterfaceDevice.HidReportType reportType, System.UInt16 usagePage, System.UInt16 usageId)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.GetBooleanControlDescriptions

## -description

Retrieves the descriptions of the boolean controls for the given HID device.

## -parameters

### -param reportType

Specifies the type of report for which the control descriptions are requested.

### -param usagePage

Identifies the usage page associated with the controls.

A value of 0 is treated as a wild card for all usage pages.

### -param usageId

Identifies the usage associated with the controls.

A value of 0 is treated as a wild card for all usage IDs.

## -returns

A vector of [HidBooleanControlDescription](hidbooleancontroldescription.md) objects.

## -remarks

Boolean controls are simple controls that return On/Off values. (They are sometimes referred to as button controls.)

## -examples

## -see-also

### Samples

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
