---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.GetFeatureReportAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.HumanInterfaceDevice.HidFeatureReport> GetFeatureReportAsync()
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.GetFeatureReportAsync

## -description
Asynchronously retrieves the first, or default, feature report from the given HID device.

## -returns
A **HidFeatureReport** object.

## -remarks
This instance of the method retrieves the first available feature report.

The device must be opened with either [FileAccessMode.Read](../windows.storage/fileaccessmode.md) or [FileAccessMode.ReadWrite](../windows.storage/fileaccessmode.md).

## -examples

## -see-also

### Reference

[GetFeatureReportAsync(UInt16)](hiddevice_getfeaturereportasync_1194285243.md), [Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
