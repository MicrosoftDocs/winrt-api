---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.GetFeatureReportAsync(System.UInt16)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.HumanInterfaceDevice.HidFeatureReport> GetFeatureReportAsync(System.UInt16 reportId)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.GetFeatureReportAsync

## -description
Asynchronously retrieves a feature report, identified by the *reportId* parameter, for the given HID device.

## -parameters
### -param reportId
Identifies the requested feature report.

## -returns
A **HidFeatureReport** object.

## -remarks
The device must be opened with either [FileAccessMode.Read](../windows.storage/fileaccessmode.md) or [FileAccessMode.ReadWrite](../windows.storage/fileaccessmode.md).

## -examples

## -see-also

[GetFeatureReportAsync](hiddevice_getfeaturereportasync_706664006.md), [Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
