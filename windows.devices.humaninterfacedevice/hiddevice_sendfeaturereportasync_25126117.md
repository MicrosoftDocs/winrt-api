---
-api-id: M:Windows.Devices.HumanInterfaceDevice.HidDevice.SendFeatureReportAsync(Windows.Devices.HumanInterfaceDevice.HidFeatureReport)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<uint> SendFeatureReportAsync(Windows.Devices.HumanInterfaceDevice.HidFeatureReport featureReport)
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.SendFeatureReportAsync

## -description

Sends an feature report asynchronously from the host to the device.

## -parameters

### -param featureReport

The feature report which the host sends to the device.

## -returns

The result of the asynchronous operation.

## -remarks
The device must be opened with either [FileAccessMode.Read](../windows.storage/fileaccessmode.md) or [FileAccessMode.ReadWrite](../windows.storage/fileaccessmode.md).

## -examples

## -see-also

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
