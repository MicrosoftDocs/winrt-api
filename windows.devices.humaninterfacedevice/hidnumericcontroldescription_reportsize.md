---
-api-id: P:Windows.Devices.HumanInterfaceDevice.HidNumericControlDescription.ReportSize
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint ReportSize { get; }
-->

# Windows.Devices.HumanInterfaceDevice.HidNumericControlDescription.ReportSize

## -description

Gets the size of the data field for the usage in a report.

## -property-value

The data field size (in bits).

## -remarks

If [ReportCount](hidnumericcontroldescription_reportcount.md) is greater than one, each usage has a separate data field of this size.

## -examples

## -see-also

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
