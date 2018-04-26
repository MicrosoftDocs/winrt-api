---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.GetNumericControlDescriptions(Windows.Devices.HumanInterfaceDevice.HidReportType,System.UInt16,System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.HumanInterfaceDevice.HidNumericControlDescription> GetNumericControlDescriptions(Windows.Devices.HumanInterfaceDevice.HidReportType reportType, System.UInt16 usagePage, System.UInt16 usageId)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.GetNumericControlDescriptions

## -description
Retrieves the descriptions of the numeric controls for the given HID device.

## -parameters
### -param reportType
Specifies the type of report for which the control descriptions are requested.

### -param usagePage
Identifies the usage page associated with the controls.

### -param usageId
Identifies the usage associated with the controls.

## -returns
A vector of [HidNumericControlDescription](hidnumericcontroldescription.md) objects.

## -remarks

## -examples

## -see-also

### Samples

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
